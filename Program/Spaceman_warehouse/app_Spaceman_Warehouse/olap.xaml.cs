using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace app_Spaceman_Warehouse
{
    /// <summary>
    /// Interaction logic for olap.xaml
    /// </summary>
    public partial class olap : UserControl
    {
        MainWindow root;
        pivot_pemesanan  pivot = new pivot_pemesanan();
        olap_menu menu_content = null;
        public olap(MainWindow x, string y)
        {
            InitializeComponent();
            root = x;
            menu_content = new olap_menu(root);
            menu.Children.Clear();
            menu.Children.Add(menu_content);
            
            this.Width = root.Width;
            this.Height = root.Height - (root.header.Height + root.footer.Height) - 4;
            menu_olap.Height = this.Height;

            olap_content.Children.Clear();
            olap_content.Children.Add(pivot);
            if (y == "")
            {
                header_txt.Text = "Pemesanan Produk";
            }
            else
            {
                header_txt.Text = y;
            } 
           
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void submenulabel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void submenubtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Storyboard x = new Storyboard();
            if (menu_olap.Width > 35)
            {
                x = (Storyboard)TryFindResource("hide_olap");
                x.Begin();
            }
            else
            {
                x = (Storyboard)TryFindResource("tampil_olap");
                x.Begin();
            }
        }

        private void olap_content_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            pivot.pivot.Height = olap_content.Height;
        }

        private void menu_olap_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            
            
        }
    }
}

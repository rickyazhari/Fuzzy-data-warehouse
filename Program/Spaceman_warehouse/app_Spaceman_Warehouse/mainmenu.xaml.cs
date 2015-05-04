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
    /// Interaction logic for mainmenu.xaml
    /// </summary>
    public partial class mainmenu : UserControl
    {
        MainWindow root;
        Storyboard sb;
        public mainmenu(MainWindow x)
        {
            InitializeComponent();
            root = x;
        }

        private void menu_etl_MouseEnter(object sender, MouseEventArgs e)
        {
            sb = new Storyboard();
            sb = (Storyboard)TryFindResource("etl_enter");
            sb.Begin();
        }

        private void menu_etl_MouseLeave(object sender, MouseEventArgs e)
        {
            sb = new Storyboard();
            sb = (Storyboard)TryFindResource("etl_leave");
            sb.Begin();
        }

        private void menu_dimensi_MouseEnter(object sender, MouseEventArgs e)
        {
            sb = new Storyboard();
            sb = (Storyboard)TryFindResource("dimensi_enter");
            sb.Begin();
        }

        private void menu_dimensi_MouseLeave(object sender, MouseEventArgs e)
        {
            sb = new Storyboard();
            sb = (Storyboard)TryFindResource("dimensi_leave");
            sb.Begin();
        }

        private void menu_fakta_MouseEnter(object sender, MouseEventArgs e)
        {
            sb = new Storyboard();
            sb = (Storyboard)TryFindResource("fakta_enter");
            sb.Begin();
        }

        private void menu_fakta_MouseLeave(object sender, MouseEventArgs e)
        {
            sb = new Storyboard();
            sb = (Storyboard)TryFindResource("fakta_leave");
            sb.Begin();
        }

        private void menu_olap_MouseEnter(object sender, MouseEventArgs e)
        {
            sb = new Storyboard();
            sb = (Storyboard)TryFindResource("olap_enter");
            sb.Begin();
        }

        private void menu_olap_MouseLeave(object sender, MouseEventArgs e)
        {
            sb = new Storyboard();
            sb = (Storyboard)TryFindResource("olap_leave");
            sb.Begin();
        }

        private void menu_etl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.uc_handle("Proses ETL");
        }

        private void menu_dimensi_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.uc_handle("dimensi");
        }
    }
}

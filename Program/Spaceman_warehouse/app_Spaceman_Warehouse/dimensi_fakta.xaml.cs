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
    /// Interaction logic for dimensi_fakta.xaml
    /// </summary>
    public partial class dimensi_fakta : UserControl
    {
        MainWindow root;
        UserControl menu_content;
        public dimensi_fakta( MainWindow x, string y)
        {
            InitializeComponent();
            root = x;
            if (y == "dimensi")
            {
                menu_content = new dimensi_menu(root);
                menu.Children.Clear();
                menu.Children.Add(menu_content);
            }
            else
            {

            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}

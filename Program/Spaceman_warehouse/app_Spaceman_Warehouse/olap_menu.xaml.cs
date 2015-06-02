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

namespace app_Spaceman_Warehouse
{
    /// <summary>
    /// Interaction logic for olap_menu.xaml
    /// </summary>
    public partial class olap_menu : UserControl
    {
        MainWindow root;
        public olap_menu(MainWindow x)
        {
            InitializeComponent();
            root = x;
        }
    }
}

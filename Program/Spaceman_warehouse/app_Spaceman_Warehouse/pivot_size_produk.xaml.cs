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
    /// Interaction logic for pivot_size_produk.xaml
    /// </summary>
    public partial class pivot_size_produk : UserControl
    {
        public pivot_size_produk()
        {
            InitializeComponent();
            jumlah_produk.IsChecked = true;
        }

        private void jumlah_produk_Checked(object sender, RoutedEventArgs e)
        {
            data_area.Caption = "Jumlah Produk";
            data_area.FieldName = "[Measures].[Jumlah]";
        }

        private void jumlah_size_Checked(object sender, RoutedEventArgs e)
        {
            data_area.Caption = "Jumlah Size";
            data_area.FieldName = "[Measures].[Fact Size Produk Count]";
        }
    }
}

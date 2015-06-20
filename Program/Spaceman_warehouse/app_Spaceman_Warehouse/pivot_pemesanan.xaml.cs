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
using DevExpress.PivotGrid;

namespace app_Spaceman_Warehouse
{
    /// <summary>
    /// Interaction logic for pivot_pemesanan.xaml
    /// </summary>
    public partial class pivot_pemesanan : UserControl
    {
        public pivot_pemesanan()
        {
            InitializeComponent();
            saldo_order.IsChecked = true;
           
        }

        private void saldo_order_Checked(object sender, RoutedEventArgs e)
        {
            data_area.Caption = "Saldo";
            data_area.FieldName = "[Measures].[saldo]";
            data_area.CellFormat = "c2";
        }

        private void jumlah_produk_Checked(object sender, RoutedEventArgs e)
        {
            data_area.Caption = "Jumlah Produk";
            data_area.FieldName = "[Measures].[Jumlah]";
            data_area.CellFormat = null;
        }

        private void jumlah_order_Checked(object sender, RoutedEventArgs e)
        {
            data_area.Caption = "Jumlah Order";
            data_area.FieldName = "[Measures].[Fact Pemesanan Count]";
            data_area.CellFormat = null;
        }

       
    }
}

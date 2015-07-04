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
    /// Interaction logic for pivot_pengiriman_produk.xaml
    /// </summary>
    public partial class pivot_pengiriman_produk : UserControl
    {
        public pivot_pengiriman_produk()
        {
            InitializeComponent();
            biaya_pengiriman.IsChecked = true;
        }

        private void biaya_pengiriman_Checked(object sender, RoutedEventArgs e)
        {
            data_area.Caption = "Biaya Pengiriman";
            data_area.FieldName = "[Measures].[Saldo]";
            data_area.CellFormat = "c2";
        }

        private void jumlah_produk_Checked(object sender, RoutedEventArgs e)
        {
            data_area.Caption = "Jumlah Produk";
            data_area.FieldName = "[Measures].[Jumlah]";
            data_area.CellFormat = "";
        }

        private void jumlah_jenis_pengiriman_Checked(object sender, RoutedEventArgs e)
        {
            data_area.Caption = "Jumlah Jenis Pengiriman";
            data_area.FieldName = "[Measures].[Fact Pengiriman Produk Count]";
            data_area.CellFormat = "";
        }
    }
}

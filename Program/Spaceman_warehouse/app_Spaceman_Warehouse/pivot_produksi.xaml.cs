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
    /// Interaction logic for pivot_produksi.xaml
    /// </summary>
    public partial class pivot_produksi : UserControl
    {
        public pivot_produksi()
        {
            InitializeComponent();
            biaya.IsChecked = true;
        }

        private void biaya_Checked(object sender, RoutedEventArgs e)
        {
            data_area.Caption = "Biaya Produksi";
            data_area.FieldName = "[Measures].[Biaya Produksi]";
            data_area.CellFormat = "c2";
        }

        private void jumlah_Checked(object sender, RoutedEventArgs e)
        {
            data_area.Caption = "Jumlah Produksi";
            data_area.FieldName = "[Measures].[Jumlah]";
            data_area.CellFormat = "";
        }
    }
}

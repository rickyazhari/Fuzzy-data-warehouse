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
    /// Interaction logic for pivot_belanja.xaml
    /// </summary>
    public partial class pivot_belanja : UserControl
    {
        public pivot_belanja()
        {
            InitializeComponent();
            kredit.IsChecked = true;
        }

        private void kredit_Checked(object sender, RoutedEventArgs e)
        {
            data_area.Caption = "Kredit";
            data_area.FieldName = "[Measures].[Cost]";
            data_area.CellFormat = "c2";
        }

        private void Jumlah_Checked(object sender, RoutedEventArgs e)
        {
            data_area.Caption = "Jumlah";
            data_area.FieldName = "[Measures].[Jumlah Kredit]";
            data_area.CellFormat = "";
        }
    }
}

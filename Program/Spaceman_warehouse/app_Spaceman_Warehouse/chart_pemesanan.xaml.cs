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
    /// Interaction logic for chart_pemesanan.xaml
    /// </summary>
    public partial class chart_pemesanan : UserControl
    {
        pivot_pemesanan data;
        public chart_pemesanan(pivot_pemesanan x)
        {
            InitializeComponent();
            data = x;
            bar_chart.DataSource = x.pivot.ChartDataSource;
        }
    }
}

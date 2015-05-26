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
using System.Threading;
using System.ComponentModel;
using Microsoft.SqlServer.Dts.Runtime;
using FirstFloor.ModernUI.Windows.Controls;


namespace app_Spaceman_Warehouse
{
    /// <summary>
    /// Interaction logic for etl_load.xaml
    /// </summary>
    public partial class etl_load : UserControl
    {
        extract_transform_load paket = new extract_transform_load();
        MainWindow root;
        Storyboard m = new Storyboard();
        string stat = "";
        
        public etl_load(MainWindow x)
        {
            InitializeComponent();
            root = x;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
           
    
            m = (Storyboard)TryFindResource("loading");
            m.Begin();
            load_background();
        }


        private void load_background()
        {
            var bw = new BackgroundWorker();
            

            bw.DoWork += (sender, args) =>
            {

                paket.proses_etl().Execute();

            };
            bw.RunWorkerCompleted += (sender, args) =>
           {
               stat = paket.proses_etl().ExecutionResult.ToString();
               paket = null;
               ModernDialog.ShowMessage("ETL Process execution " + stat, "Informasi", MessageBoxButton.OK);
               root.uc_handle(stat.ToLower());
               
           };

            bw.RunWorkerAsync();
        }
    }
}

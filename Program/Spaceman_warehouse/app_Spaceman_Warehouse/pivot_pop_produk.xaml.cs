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
using DevExpress.Xpf.PivotGrid;
using System.Windows.Markup;

namespace app_Spaceman_Warehouse
{
    /// <summary>
    /// Interaction logic for pivot_pop_produk.xaml
    /// </summary>
    public partial class pivot_pop_produk : UserControl
    {
        int col = 1;
        int row = 0;
        int appearindex = 1;
        public pivot_pop_produk()
        {
            InitializeComponent();
            pivot.ShowRowTotals = false;
        }

        private void pivot_FieldAreaChanged(object sender, PivotFieldEventArgs e)
        {
            
            
        }

        private void pivot_CustomCellAppearance(object sender, PivotCustomCellAppearanceEventArgs e)
        {
            /* double max = 0;
             for (int i = 0; i < pivot.RowCount; i++)
             {
                 if (max < Convert.ToDouble(e.GetCellValue(col, i)))
                 {
                     max = Convert.ToDouble(e.GetCellValue(col, i));
                 }
             }
             Brush asal = e.Background;

             if (Convert.ToDouble(e.GetCellValue(persentasi)) == max)
             {
                 e.Background = new SolidColorBrush(Color.FromRgb(0,139,255));
             }
             //MessageBox.Show(max.ToString());
            // MessageBox.Show(appearindex.ToString());
             //MessageBox.Show(col.ToString());
             
            
              if (appearindex == 2)
              {
                  appearindex = 1;
                  col += 2;
              }
              else
              {
                  appearindex++;
              }

              if (col > pivot.ColumnCount - 1)
              {
                  col = 1;
              }*/
        }

        private void pivot_FieldAreaIndexChanged(object sender, PivotFieldEventArgs e)
        {
            /*if (tahun.AreaIndex > kelas.AreaIndex)
            {
                MessageBox.Show(tahun.AreaIndex.ToString());
                top_item.ColumnName = "kelas";
                top_avg.ColumnName = "kelas";
                bot_item.ColumnName = "kelas";
                
            }
            else
            {
                MessageBox.Show(tahun.AreaIndex.ToString());
                top_item.ColumnName = "tahun";
                top_avg.ColumnName = "tahun";
                bot_item.ColumnName = "tahun";
            }*/
        }

        private void pivot_FieldValueExpanded(object sender, PivotFieldValueEventArgs e)
        {
         /*   if (sender == tahun)
            {
                top_item.ColumnName = "kelas";
                top_avg.ColumnName = "kelas";
                bot_item.ColumnName = "kelas";
            }
            else
            {

            }*/
        }
    }
}

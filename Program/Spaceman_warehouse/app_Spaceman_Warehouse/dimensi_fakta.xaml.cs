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
using System.Data;

namespace app_Spaceman_Warehouse
{
    /// <summary>
    /// Interaction logic for dimensi_fakta.xaml
    /// </summary>
    public partial class dimensi_fakta : UserControl
    {
        MainWindow root;
        UserControl menu_content;
        kon sql = new kon();
        private string com = "";
        private DataTable tabel_dw = new DataTable();
        public int page_lower = 1;
        private int show_page = 10;
        private int row_count = 0;
        public string status_tabel = "";
        public string status_content = "";
        public int paging_data = 1;
        public dimensi_fakta( MainWindow x, string y, string z)
        {
            InitializeComponent();
            root = x;
            status_tabel = y;
            status_content = z;
            if (y == "dimensi")
            {
                menu_content = new dimensi_menu(root);
                menu.Children.Clear();
                menu.Children.Add(menu_content);
            }
            else
            {

            }
            split_border.Height = root.Height - (root.header.Height + root.footer.Height);
            status_tabel = y;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (status_tabel == "dimensi")
            {
               uc_dimensi_handle(status_content,page_lower);
            }
            else
            {

            }
        }

        private void uc_dimensi_handle(string x, int y)
        {
            status_content = x;
             switch (status_content)
                {
                    case "konsumen" :
                        content_header.Text = "Dimensi Konsumen";
                        com = "select * from dim_konsumen";
                        root.status_content.Text = "Dimensi Konsumen";
                        break;
                    case "produk"   :
                        content_header.Text = "Dimensi Produk";
                        com = "select * from dim_Produk";
                        root.status_content.Text = "Dimensi Produk";
                        break;
                    case "pengiriman" :
                        content_header.Text = "Dimensi Pengiriman";
                        com = "select * from dim_pengiriman";
                        root.status_content.Text = "Dimensi Pengiriman";
                        break;
                    case "kredit"   :
                        content_header.Text = "Dimensi Kredit";
                        com = "select * from dim_kredit";
                        root.status_content.Text = "Dimensi Kredit";
                        break;
                    case "design"   :
                        content_header.Text = "Dimensi Design";
                        com = "select * from dim_design";
                        root.status_content.Text = "Dimensi Design";
                        break;
                    case "staff_produksi" :
                        content_header.Text = "Dimensi Staff Produksi";
                        com = "select * from dim_staff_produksi";
                        root.status_content.Text = "Dimensi Staff Produksi";
                        break;
                    case "size" :
                        content_header.Text = "Dimensi Size";
                        com = "select * from dim_size";
                        root.status_content.Text = "Dimensi Size";
                        break;
                    case "job"  :
                        content_header.Text = "Dimensi Job";
                        com = "select * from dim_job";
                        root.status_content.Text = "Dimensi Job";
                        break;
                    default:
                        content_header.Text = "Dimensi Waktu";
                        com = "select * from dim_waktu";
                        root.status_content.Text = "Dimensi Waktu";
                        break;
                }
            page_lower = y;
            tabel_dw = new DataTable();
            tabel_dw = sql.tampil_data(com);
            row_count = tabel_dw.Rows.Count;
            if (row_count > 0)
            {
                DataTable temp = new DataTable();
                temp = tabel_dw.Clone();
                if(row_count > (show_page+page_lower)-1)
                {
                    for (int i = page_lower; i < (show_page+page_lower); i++)
                    {
                        temp.ImportRow(tabel_dw.Rows[i-1]);
                    }
                    border_status_list_content.Text = page_lower + " - " + ((page_lower + show_page) - 1) + " dari " + row_count + " row";
                }
                else
                {
                    for (int i = page_lower; i <= tabel_dw.Rows.Count; i++)
                    {
                        temp.ImportRow(tabel_dw.Rows[i-1]);
                    }
                    border_status_list_content.Text = page_lower + " - " + row_count + " dari " + row_count + " row";
                }
                
                tabel_view.DataContext = temp.DefaultView;
                tabel_dw.Dispose();
                temp.Dispose();
            }
            else
            {

            }
           
        }

        private void border_button_next_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if ((page_lower + show_page)-1  < row_count)
            {
                page_lower += show_page;
                border_status_list_content.Text = page_lower+" - "+((show_page+page_lower)-1)+" dari "+ row_count+" row";
                Storyboard x = new Storyboard();
                x = (Storyboard)TryFindResource("fade_tabel");
                x.Begin();
            }
            else
            {
                border_status_list_content.Text = page_lower + " - " + row_count + " dari " + row_count + " row";
                
            }
            uc_dimensi_handle(status_content, page_lower);
            
        }

        private void border_button_prev_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (page_lower > 1)
            {
                page_lower -= show_page;
                uc_dimensi_handle(status_content,page_lower);
                Storyboard x = new Storyboard();
                x = (Storyboard)TryFindResource("fade_tabel");
                x.Begin();
            }
        }

        private void border_button_last_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (row_count > show_page)
            {
                if (row_count % show_page == 0)
                {
                    page_lower = (row_count - show_page) + 1;
                }
                else
                {
                    page_lower = (row_count - (row_count % show_page)) + 1;
                }
                uc_dimensi_handle(status_content, page_lower);
                Storyboard x = new Storyboard();
                x = (Storyboard)TryFindResource("fade_tabel");
                x.Begin();
            }
        }

        private void border_button_first_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (page_lower > 1)
            {
                uc_dimensi_handle(status_content, 1);
                Storyboard x = new Storyboard();
                x = (Storyboard)TryFindResource("fade_tabel");
                x.Begin();
            }
        }

        private void border_button_first_MouseEnter(object sender, MouseEventArgs e)
        {
            Storyboard x = new Storyboard();
            x = (Storyboard)TryFindResource("first_enter");
            x.Begin();
        }

        private void border_button_first_MouseLeave(object sender, MouseEventArgs e)
        {
            Storyboard x = new Storyboard();
            x = (Storyboard)TryFindResource("first_leave");
            x.Begin();
        }

        private void border_button_prev_MouseEnter(object sender, MouseEventArgs e)
        {
            Storyboard x = new Storyboard();
            x = (Storyboard)TryFindResource("prev_enter");
            x.Begin();
        }

        private void border_button_prev_MouseLeave(object sender, MouseEventArgs e)
        {
            Storyboard x = new Storyboard();
            x = (Storyboard)TryFindResource("prev_leave");
            x.Begin();
        }

        private void border_button_next_MouseEnter(object sender, MouseEventArgs e)
        {
            Storyboard x = new Storyboard();
            x = (Storyboard)TryFindResource("next_enter");
            x.Begin();
        }

        private void border_button_next_MouseLeave(object sender, MouseEventArgs e)
        {
            Storyboard x = new Storyboard();
            x = (Storyboard)TryFindResource("next_leave");
            x.Begin();
        }

        private void border_button_last_MouseEnter(object sender, MouseEventArgs e)
        {
            Storyboard x = new Storyboard();
            x = (Storyboard)TryFindResource("last_enter");
            x.Begin();
        }

        private void border_button_last_MouseLeave(object sender, MouseEventArgs e)
        {
            
            Storyboard x = new Storyboard();
            x = (Storyboard)TryFindResource("last_leave");
            x.Begin();
        }
    }
}

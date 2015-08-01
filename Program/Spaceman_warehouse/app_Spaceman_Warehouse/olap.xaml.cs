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
using FirstFloor.ModernUI.Windows.Controls;
using DevExpress.Xpf.Printing;
using DevExpress.Xpf.Utils;

namespace app_Spaceman_Warehouse
{
    /// <summary>
    /// Interaction logic for olap.xaml
    /// </summary>
    public partial class olap : UserControl
    {
        MainWindow root;
        pivot_pemesanan  pivot = new pivot_pemesanan();
        pivot_pop_produk populer_produk = new pivot_pop_produk();
        pivot_pop_design populer_design = new pivot_pop_design();
        pivot_pelunasan pelunasan = new pivot_pelunasan();
        pivot_size_produk size_produk = new pivot_size_produk();
        pivot_pengiriman_produk pengiriman_produk = new pivot_pengiriman_produk();
        pivot_belanja belanja = new pivot_belanja();
        pivot_produksi produksi = new pivot_produksi();
        olap_menu menu_content = null;
        string pointer="";
        public olap(MainWindow x, string y)
        {
            InitializeComponent();
            root = x;
            menu_content = new olap_menu(root);
            menu.Children.Clear();
            menu.Children.Add(menu_content);
            
            this.Width = root.Width;
            this.Height = root.Height - (root.header.Height + root.footer.Height) - 4;
            menu_olap.Height = this.Height;
            olap_content.Height = menu_olap.Height - btn_control.Height- olap_header.Height;
            olap_handle(y);
            resizing_pivot(); 
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void submenulabel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void submenubtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Storyboard x = new Storyboard();
            if (menu_olap.Width > 35)
            {
                x = (Storyboard)TryFindResource("hide_olap");
                x.Begin();
            }
            else
            {
                x = (Storyboard)TryFindResource("tampil_olap");
                x.Begin();
            }
        }

        private void olap_content_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            resizing_pivot();
        }

        private void menu_olap_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            
            
        }

        public void olap_handle(string x)
        {
            pointer = x;
            switch(x)
            {
                case "pop_produk" :
                    header_txt.Text = "Kepopuleran Produk";
                    olap_content.Children.Clear();
                    olap_content.Children.Add(populer_produk);
                    root.status_content.Text = "Pivot Kepopuleran Produk";                  
                    root.fading();
                    break;

                case "pelunasan":
                    header_txt.Text = "Pelunasan Konsumen";
                    olap_content.Children.Clear();
                    olap_content.Children.Add(pelunasan);
                    root.status_content.Text = "Pivot Pelunasan Konsumen";    
                    root.fading();
                    break;

                case "produksi":
                    header_txt.Text = "Produksi Produk";
                    olap_content.Children.Clear();
                    olap_content.Children.Add(produksi);
                    root.status_content.Text = "Pivot Produksi Produk";    
                    root.fading();
                    break;

                case "belanja":
                    header_txt.Text = "Belanja";
                    olap_content.Children.Clear();
                    olap_content.Children.Add(belanja);
                    root.status_content.Text = "Pivot Belanja";    
                    root.fading();
                    break;

                case "pengiriman":
                    header_txt.Text = "Pengiriman Produk";
                    olap_content.Children.Clear();
                    olap_content.Children.Add(pengiriman_produk);
                    root.status_content.Text = "Pivot Pengiriman";    
                    root.fading();
                    break;

                case "size":
                    header_txt.Text = "Size Produk";
                    olap_content.Children.Clear();
                    olap_content.Children.Add(size_produk);
                    root.status_content.Text = "Pivot Size";    
                    root.fading();
                    break;

                case "pop_design":
                    header_txt.Text = "Kepopuleran Design";
                    olap_content.Children.Clear();
                    olap_content.Children.Add(populer_design);
                    root.status_content.Text = "Pivot Kepopuleran Design";    
                    root.fading();
                    break;
                
                default :
                    header_txt.Text = "Pemesanan Produk";
                    olap_content.Children.Clear();
                    olap_content.Children.Add(pivot);
                    root.status_content.Text = "Pivot Pemesanan Produk";    
                    root.fading();
                    break;
            }
            
        }

        private void btn_print_MouseEnter(object sender, MouseEventArgs e)
        {
            Storyboard sb = new Storyboard();
            sb = (Storyboard)TryFindResource("btn_pivot_enter");
            sb.Begin();
        }

        private void btn_print_MouseLeave(object sender, MouseEventArgs e)
        {
            Storyboard sb = new Storyboard();
            sb = (Storyboard)TryFindResource("btn_pivot_leave");
            sb.Begin();
        }

        private void btn_chart_MouseEnter(object sender, MouseEventArgs e)
        {
            Storyboard sb = new Storyboard();
            sb = (Storyboard)TryFindResource("btn_chart_enter");
            sb.Begin();
        }

        private void btn_chart_MouseLeave(object sender, MouseEventArgs e)
        {
            Storyboard sb = new Storyboard();
            sb = (Storyboard)TryFindResource("btn_chart_leave");
            sb.Begin();
        }

        private void btn_print_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            PrintableControlLink pcl = new PrintableControlLink(pivot.pivot);
            switch (pointer)
            {

                case "pop_produk":
                    pcl = new PrintableControlLink(populer_produk.pivot);
                    pcl.PageHeaderTemplate = (DataTemplate)TryFindResource("page_header");
                    pcl.PageHeaderData = "KEPOPULERAN PRODUK";
                    break;

                case "pop_design":
                    pcl = new PrintableControlLink(populer_design.pivot);
                    pcl.PageHeaderTemplate = (DataTemplate)TryFindResource("page_header");
                    pcl.PageHeaderData = "KEPOPULERAN PRODUK";
                    break;

                case "pelunasan":
                    pcl = new PrintableControlLink(pelunasan.pivot);
                    pcl.PageHeaderTemplate = (DataTemplate)TryFindResource("page_header");
                    pcl.PageHeaderData = "PELUNASAN KONSUMEN";
                    break;

                case "size":
                    pcl = new PrintableControlLink(size_produk.pivot);
                    pcl.PageHeaderTemplate = (DataTemplate)TryFindResource("page_header");
                    if (size_produk.jumlah_size.IsChecked == true)
                    {
                        pcl.PageHeaderData = "SIZE PRODUK - JUMLAH SIZE";
                    }
                    else
                    {
                        pcl.PageHeaderData = "SIZE PRODUK - JUMLAH PRODUK";
                    }
                    break;

                case "pengiriman":
                    pcl = new PrintableControlLink(pengiriman_produk.pivot);
                    pcl.PageHeaderTemplate = (DataTemplate)TryFindResource("page_header");
                    if (pengiriman_produk.jumlah_produk.IsChecked == true)
                    {
                        pcl.PageHeaderData = "PENGIRIMAN PRODUK - JUMLAH PRODUK";
                    }
                    else if (pengiriman_produk.jumlah_jenis_pengiriman.IsChecked == true)
                    {
                        pcl.PageHeaderData = "PENGIRIMAN PRODUK - JUMLAH JENIS PENGIRIMAN";
                    }
                    else
                    {
                        pcl.PageHeaderData = "PENGIRIMAN PRODUK - BIAYA PENGIRIMAN";
                    }
                    break;

                case "belanja":
                    pcl = new PrintableControlLink(belanja.pivot);
                    pcl.PageHeaderTemplate = (DataTemplate)TryFindResource("page_header");
                    if (belanja.Jumlah.IsChecked == true)
                    {
                        pcl.PageHeaderData = "BELANJA - JUMLAH PEMAKAIAN";
                    }
                    else
                    {
                        pcl.PageHeaderData = "BELANJA - KREDIT";
                    }
                    break;

                case "produksi":
                    pcl = new PrintableControlLink(produksi.pivot);
                    pcl.PageHeaderTemplate = (DataTemplate)TryFindResource("page_header");
                    if (produksi.jumlah.IsChecked == true)
                    {
                        pcl.PageHeaderData = "PRODUKSI PRODUK - JUMLAH PRODUKSI";
                    }
                    else
                    {
                        pcl.PageHeaderData = "PRODUKSI PRODUK - BIAYA PRODUKSI";
                    }
                    break;

                default :
                   pcl = new PrintableControlLink(pivot.pivot);
                    pcl.PageHeaderTemplate = (DataTemplate)TryFindResource("page_header");
                    if (pivot.jumlah_produk.IsChecked == true)
                    {
                        pcl.PageHeaderData = "PEMESANAN PRODUK - JUMLAH PRODUK";
                    }
                    else if (pivot.jumlah_order.IsChecked == true)
                    {
                        pcl.PageHeaderData = "PEMESANAN PRODUK - JUMLAH ORDER";
                    }
                    else
                    {
                        pcl.PageHeaderData = "PEMESANAN PRODUK - SALDO ORDER";
                    }
                    break;
            }
           
            pcl.Landscape = true;
            pcl.PaperKind = System.Drawing.Printing.PaperKind.A4; 
            pcl.CreateDocument(true);
            pcl.ShowPrintPreviewDialog(root, "Print Preview");
            

        }

        private void btn_chart_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            switch (pointer)
            {
                case "pop_produk":
                    populer_produk.pivot_height.Height = new GridLength(0);
                    populer_produk.chart_height.Height = new GridLength(olap_content.Height);
                    break;
                case "pop_design":
                    populer_design.pivot_height.Height = new GridLength(0);
                    populer_design.chart_height.Height = new GridLength(olap_content.Height);
                    break;
                case "pelunasan":
                    pelunasan.pivot_height.Height = new GridLength(0);
                    pelunasan.chart_height.Height = new GridLength(olap_content.Height);
                    break;
                case "size":
                    size_produk.pivot_height.Height = new GridLength(0);
                    size_produk.chart_height.Height = new GridLength(olap_content.Height - 60);
                    break;
                case "pengiriman":
                    pengiriman_produk.pivot_height.Height = new GridLength(0);
                    pengiriman_produk.chart_height.Height = new GridLength(olap_content.Height - 60);
                    break;
                case "belanja":
                    belanja.pivot_height.Height = new GridLength(0);
                    belanja.chart_height.Height = new GridLength(olap_content.Height - 60);
                    break;
                case "produksi":
                    produksi.pivot_height.Height = new GridLength(0);
                    produksi.chart_height.Height = new GridLength(olap_content.Height - 60);
                    break;
                default :
                    pivot.pivot_height.Height = new GridLength(0);
                    //pivot.print_height.Height = new GridLength(0);
                    pivot.chart_height.Height = new GridLength(olap_content.Height - 60);
                    break;
            }
            
        }

        private void resizing_pivot()
        {
            switch (pointer)
            {
                case "pop_produk":
                    if (populer_produk.pivot_height.Height.Value > 0)
                    {
                        populer_produk.pivot_height.Height = new GridLength(olap_content.Height);
                    }
                    else 
                    {
                        populer_produk.chart_height.Height = new GridLength(olap_content.Height);
                    }
                    break;

                case "pop_design":
                    if (populer_design.pivot_height.Height.Value > 0)
                    {
                        populer_design.pivot_height.Height = new GridLength(olap_content.Height);
                    }
                    else
                    {
                        populer_design.chart_height.Height = new GridLength(olap_content.Height);
                    }
                    break;

                case "pelunasan":
                    if (pelunasan.pivot_height.Height.Value > 0)
                    {
                        pelunasan.pivot_height.Height = new GridLength(olap_content.Height);
                    }
                    else
                    {
                        pelunasan.chart_height.Height = new GridLength(olap_content.Height);
                    }
                    break;

                case "size":
                    if (size_produk.pivot_height.Height.Value > 0)
                    {
                        size_produk.pivot_height.Height = new GridLength(olap_content.Height - 60);
                    }
                    else
                    {
                        size_produk.chart_height.Height = new GridLength(olap_content.Height - 60);
                    }
                    break;

                case "pengiriman":
                    if (pengiriman_produk.pivot_height.Height.Value > 0)
                    {
                        pengiriman_produk.pivot_height.Height = new GridLength(olap_content.Height - 60);
                    }
                    else
                    {
                        pengiriman_produk.chart_height.Height = new GridLength(olap_content.Height - 60);
                    }
                    break;

                case "belanja":
                    if (belanja.pivot_height.Height.Value > 0)
                    {
                        belanja.pivot_height.Height = new GridLength(olap_content.Height - 60);
                    }
                    else
                    {
                        belanja.chart_height.Height = new GridLength(olap_content.Height - 60);
                    }
                    break;

                case "produksi":
                    if (produksi.pivot_height.Height.Value > 0)
                    {
                        produksi.pivot_height.Height = new GridLength(olap_content.Height - 60);
                    }
                    else
                    {
                        produksi.chart_height.Height = new GridLength(olap_content.Height - 60);
                    }
                    break;

                default :
                    if (pivot.pivot_height.Height.Value > 0)
                    {
                        pivot.pivot_height.Height = new GridLength(olap_content.Height - 60);
                    }
                    else
                    {
                        pivot.chart_height.Height = new GridLength(olap_content.Height - 60);
                    }
                    //else
                    //{
                    //    pivot.print_height.Height = new GridLength(olap_content.Height - 60);
                    //}
                    break;
            }
           
        }

        private void btn_pivot_MouseEnter(object sender, MouseEventArgs e)
        {
            Storyboard sb = new Storyboard();
            sb = (Storyboard)TryFindResource("btn_pivot_data_enter");
            sb.Begin();
        }

        private void btn_pivot_MouseLeave(object sender, MouseEventArgs e)
        {
            Storyboard sb = new Storyboard();
            sb = (Storyboard)TryFindResource("btn_pivot_data_leave");
            sb.Begin();
        }

        private void btn_pivot_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            switch (pointer)
            {
                case "pop_produk":
                    populer_produk.pivot_height.Height = new GridLength(olap_content.Height);
                    populer_produk.chart_height.Height = new GridLength(0);
                    break;
                case "pop_design":
                    populer_design.pivot_height.Height = new GridLength(olap_content.Height);
                    populer_design.chart_height.Height = new GridLength(0);
                    break;
                case "pelunasan":
                    pelunasan.pivot_height.Height = new GridLength(olap_content.Height);
                    pelunasan.chart_height.Height = new GridLength(0);
                    break;
                case "size":
                    size_produk.pivot_height.Height = new GridLength(olap_content.Height - 60);
                    size_produk.chart_height.Height = new GridLength(0);
                    break;
                case "pengiriman":
                    pengiriman_produk.pivot_height.Height = new GridLength(olap_content.Height - 60);
                    pengiriman_produk.chart_height.Height = new GridLength(0);
                    break;
                case "belanja":
                    belanja.pivot_height.Height = new GridLength(olap_content.Height - 60);
                    belanja.chart_height.Height = new GridLength(0);
                    break;
                case "produksi":
                    produksi.pivot_height.Height = new GridLength(olap_content.Height - 60);
                    produksi.chart_height.Height = new GridLength(0);
                    break;
                default:
                    pivot.pivot_height.Height = new GridLength(olap_content.Height - 60);
                    pivot.chart_height.Height = new GridLength(0);
                    //pivot.print_height.Height = new GridLength(0);
                    break;
            }
        }
    }
}

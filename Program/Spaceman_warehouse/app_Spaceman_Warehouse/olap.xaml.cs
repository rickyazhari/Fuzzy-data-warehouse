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
            PrintableControlLink link = new PrintableControlLink(pivot.pivot);
            link.PageHeaderTemplate = (DataTemplate)TryFindResource("header_pemesanan");
            link.PageHeaderData = "SPACEMAN";
            link.ShowPrintPreviewDialog(root,"Print Preview");
        }

        private void btn_chart_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            switch (pointer)
            {
                case "pop_produk":
                    populer_produk.pivot_height.Height = new GridLength(0);
                    populer_produk.chart_height.Height = new GridLength(olap_content.Height);
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
           
            
           
            populer_design.pivot.Height = olap_content.Height;
            pelunasan.pivot.Height = olap_content.Height;
            size_produk.pivot.Height = olap_content.Height;
            pengiriman_produk.pivot.Height = olap_content.Height;
            belanja.pivot.Height = olap_content.Height;
            produksi.pivot.Height = olap_content.Height;
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
                default:
                    pivot.pivot_height.Height = new GridLength(olap_content.Height - 60);
                    pivot.chart_height.Height = new GridLength(0);
                    //pivot.print_height.Height = new GridLength(0);
                    break;
            }
        }
    }
}

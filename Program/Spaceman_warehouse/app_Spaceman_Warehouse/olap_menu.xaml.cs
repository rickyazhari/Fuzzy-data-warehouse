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

namespace app_Spaceman_Warehouse
{
    /// <summary>
    /// Interaction logic for olap_menu.xaml
    /// </summary>
    public partial class olap_menu : UserControl
    {
        MainWindow root;
        Storyboard sb = new Storyboard();
        public olap_menu(MainWindow x)
        {
            InitializeComponent();
            root = x;
        }

        private void fakta_pop_produk_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.olp = new olap(root, "pop_produk");
            root.content_control.Children.Clear();
            root.content_control.Children.Add(root.olp);
            root.fading();
        }

        private void fakta_pemesanan_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.olp = new olap(root, "");
            root.content_control.Children.Clear();
            root.content_control.Children.Add(root.olp);
            root.fading();
        }

        private void fakta_pemesanan_MouseEnter(object sender, MouseEventArgs e)
        {
            sb = (Storyboard)TryFindResource("fakta_pemesanan_enter");
            sb.Begin();
        }

        private void fakta_pemesanan_MouseLeave(object sender, MouseEventArgs e)
        {
            sb = (Storyboard)TryFindResource("fakta_pemesanan_leave");
            sb.Begin();
        }

        private void fakta_pop_produk_MouseEnter(object sender, MouseEventArgs e)
        {
            sb = (Storyboard)TryFindResource("fakta_pop_produk_enter");
            sb.Begin();
        }

        private void fakta_pop_produk_MouseLeave(object sender, MouseEventArgs e)
        {
            sb = (Storyboard)TryFindResource("fakta_pop_produk_leave");
            sb.Begin();
        }

        private void fakta_pop_design_MouseEnter(object sender, MouseEventArgs e)
        {
            sb = (Storyboard)TryFindResource("fakta_pop_design_enter");
            sb.Begin();
        }

        private void fakta_pop_design_MouseLeave(object sender, MouseEventArgs e)
        {
            sb = (Storyboard)TryFindResource("fakta_pop_design_leave");
            sb.Begin();
        }

        private void fakta_pembayaran_MouseEnter(object sender, MouseEventArgs e)
        {
            sb = (Storyboard)TryFindResource("fakta_pembayaran_enter");
            sb.Begin();
        }

        private void fakta_pembayaran_MouseLeave(object sender, MouseEventArgs e)
        {
            sb = (Storyboard)TryFindResource("fakta_pembayaran_leave");
            sb.Begin();
        }

        private void fakta_size_MouseEnter(object sender, MouseEventArgs e)
        {
            sb = (Storyboard)TryFindResource("fakta_size_enter");
            sb.Begin();
        }

        private void fakta_size_MouseLeave(object sender, MouseEventArgs e)
        {
            sb = (Storyboard)TryFindResource("fakta_size_leave");
            sb.Begin();
        }

        private void fakta_pengiriman_MouseEnter(object sender, MouseEventArgs e)
        {
            sb = (Storyboard)TryFindResource("fakta_pengiriman_enter");
            sb.Begin();
        }

        private void fakta_pengiriman_MouseLeave(object sender, MouseEventArgs e)
        {
            sb = (Storyboard)TryFindResource("fakta_pengiriman_leave");
            sb.Begin();
        }

        private void fakta_belanja_MouseEnter(object sender, MouseEventArgs e)
        {
            sb = (Storyboard)TryFindResource("fakta_belanja_enter");
            sb.Begin();
        }

        private void fakta_belanja_MouseLeave(object sender, MouseEventArgs e)
        {
            sb = (Storyboard)TryFindResource("fakta_belanja_leave");
            sb.Begin();
        }

        private void fakta_cost_MouseEnter(object sender, MouseEventArgs e)
        {
            sb = (Storyboard)TryFindResource("fakta_cost_enter");
            sb.Begin();
        }

        private void fakta_cost_MouseLeave(object sender, MouseEventArgs e)
        {
            sb = (Storyboard)TryFindResource("fakta_cost_leave");
            sb.Begin();
        }

        private void dim_menu_MouseEnter(object sender, MouseEventArgs e)
        {
            sb = (Storyboard)TryFindResource("dim_menu_enter");
            sb.Begin();
        }

        private void dim_menu_MouseLeave(object sender, MouseEventArgs e)
        {
            sb = (Storyboard)TryFindResource("dim_menu_leave");
            sb.Begin();
        }

        private void dim_menu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.uc_handle("success");
        }

        private void fakta_pop_design_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.olp = new olap(root, "pop_design");
            root.content_control.Children.Clear();
            root.content_control.Children.Add(root.olp);
            root.fading();
        }

        private void fakta_pembayaran_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.olp = new olap(root, "pelunasan");
            root.content_control.Children.Clear();
            root.content_control.Children.Add(root.olp);
            root.fading();
        }

        private void fakta_size_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.olp = new olap(root, "size");
            root.content_control.Children.Clear();
            root.content_control.Children.Add(root.olp);
            root.fading();
        }

        private void fakta_pengiriman_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.olp = new olap(root, "pengiriman");
            root.content_control.Children.Clear();
            root.content_control.Children.Add(root.olp);
            root.fading();
        }

        private void fakta_belanja_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.olp = new olap(root, "belanja");
            root.content_control.Children.Clear();
            root.content_control.Children.Add(root.olp);
            root.fading();
        }

        private void fakta_cost_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.olp = new olap(root, "produksi");
            root.content_control.Children.Clear();
            root.content_control.Children.Add(root.olp);
            root.fading();
        }
    }
}

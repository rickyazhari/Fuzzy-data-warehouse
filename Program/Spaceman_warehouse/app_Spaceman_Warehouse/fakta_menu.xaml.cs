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
    /// Interaction logic for fakta_menu.xaml
    /// </summary>
    public partial class fakta_menu : UserControl
    {
        MainWindow root;
        public fakta_menu( MainWindow x)
        {
            InitializeComponent();
            root = x;
        }

        private void fakta_pemesanan_MouseEnter(object sender, MouseEventArgs e)
        {
            Storyboard x = new Storyboard();
            x = (Storyboard)TryFindResource("fakta_pemesanan_enter");
            x.Begin();
        }

        private void fakta_pemesanan_MouseLeave(object sender, MouseEventArgs e)
        {
            Storyboard x = new Storyboard();
            x = (Storyboard)TryFindResource("fakta_pemesanan_leave");
            x.Begin();
        }

        private void fakta_pop_produk_MouseEnter(object sender, MouseEventArgs e)
        {
            Storyboard x = new Storyboard();
            x = (Storyboard)TryFindResource("fakta_pop_produk_enter");
            x.Begin();
        }

        private void fakta_pop_produk_MouseLeave(object sender, MouseEventArgs e)
        {
            Storyboard x = new Storyboard();
            x = (Storyboard)TryFindResource("fakta_pop_produk_leave");
            x.Begin();
        }

        private void fakta_pembayaran_MouseEnter(object sender, MouseEventArgs e)
        {
            Storyboard x = new Storyboard();
            x = (Storyboard)TryFindResource("fakta_pembayaran_enter");
            x.Begin();
        }

        private void fakta_pembayaran_MouseLeave(object sender, MouseEventArgs e)
        {
            Storyboard x = new Storyboard();
            x = (Storyboard)TryFindResource("fakta_pembayaran_leave");
            x.Begin();
        }

        private void fakta_pop_design_MouseEnter(object sender, MouseEventArgs e)
        {
            Storyboard x = new Storyboard();
            x = (Storyboard)TryFindResource("fakta_pop_design_enter");
            x.Begin();
        }

        private void fakta_pop_design_MouseLeave(object sender, MouseEventArgs e)
        {
            Storyboard x = new Storyboard();
            x = (Storyboard)TryFindResource("fakta_pop_design_leave");
            x.Begin();
        }

        private void fakta_size_MouseEnter(object sender, MouseEventArgs e)
        {
            Storyboard x = new Storyboard();
            x = (Storyboard)TryFindResource("fakta_size_enter");
            x.Begin();
        }

        private void fakta_size_MouseLeave(object sender, MouseEventArgs e)
        {
            Storyboard x = new Storyboard();
            x = (Storyboard)TryFindResource("fakta_size_leave");
            x.Begin();
        }

        private void fakta_pengiriman_MouseEnter(object sender, MouseEventArgs e)
        {
            Storyboard x = new Storyboard();
            x = (Storyboard)TryFindResource("fakta_pengiriman_enter");
            x.Begin();
        }

        private void fakta_pengiriman_MouseLeave(object sender, MouseEventArgs e)
        {
            Storyboard x = new Storyboard();
            x = (Storyboard)TryFindResource("fakta_pengiriman_leave");
            x.Begin();
        }

        private void fakta_belanja_MouseEnter(object sender, MouseEventArgs e)
        {
            Storyboard x = new Storyboard();
            x = (Storyboard)TryFindResource("fakta_belanja_enter");
            x.Begin();
        }

        private void fakta_belanja_MouseLeave(object sender, MouseEventArgs e)
        {
            Storyboard x = new Storyboard();
            x = (Storyboard)TryFindResource("fakta_belanja_leave");
            x.Begin();
        }

        private void fakta_cost_MouseEnter(object sender, MouseEventArgs e)
        {
            Storyboard x = new Storyboard();
            x = (Storyboard)TryFindResource("fakta_cost_enter");
            x.Begin();
        }

        private void fakta_cost_MouseLeave(object sender, MouseEventArgs e)
        {
            Storyboard x = new Storyboard();
            x = (Storyboard)TryFindResource("fakta_cost_leave");
            x.Begin();
        }

        private void dim_menu_MouseEnter(object sender, MouseEventArgs e)
        {
            Storyboard x = new Storyboard();
            x = (Storyboard)TryFindResource("dim_menu_enter");
            x.Begin();
        }

        private void dim_menu_MouseLeave(object sender, MouseEventArgs e)
        {
            Storyboard x = new Storyboard();
            x = (Storyboard)TryFindResource("dim_menu_leave");
            x.Begin();
        }

        private void dim_menu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.uc_handle("success");
        }

        private void fakta_pop_produk_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.mc = new dimensi_fakta(root, "fakta", "pop-produk");
            root.content_control.Children.Clear();
            root.content_control.Children.Add(root.mc);
            root.fading();
        }

        private void fakta_pop_design_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.mc = new dimensi_fakta(root, "fakta", "pop-design");
            root.content_control.Children.Clear();
            root.content_control.Children.Add(root.mc);
            root.fading();
        }

        private void fakta_pembayaran_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.mc = new dimensi_fakta(root, "fakta", "pelunasan");
            root.content_control.Children.Clear();
            root.content_control.Children.Add(root.mc);
            root.fading();
        }

        private void fakta_size_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.mc = new dimensi_fakta(root, "fakta", "size");
            root.content_control.Children.Clear();
            root.content_control.Children.Add(root.mc);
            root.fading();
        }

        private void fakta_pengiriman_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.mc = new dimensi_fakta(root, "fakta", "pengiriman");
            root.content_control.Children.Clear();
            root.content_control.Children.Add(root.mc);
            root.fading();
        }

        private void fakta_pemesanan_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.mc = new dimensi_fakta(root, "fakta", "");
            root.content_control.Children.Clear();
            root.content_control.Children.Add(root.mc);
            root.fading();
        }

        private void fakta_belanja_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.mc = new dimensi_fakta(root, "fakta", "belanja");
            root.content_control.Children.Clear();
            root.content_control.Children.Add(root.mc);
            root.fading();
        }

        private void fakta_cost_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.mc = new dimensi_fakta(root, "fakta", "produksi");
            root.content_control.Children.Clear();
            root.content_control.Children.Add(root.mc);
            root.fading();
        }
    }
}

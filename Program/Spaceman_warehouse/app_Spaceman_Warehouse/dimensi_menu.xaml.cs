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
    /// Interaction logic for dimensi_menu.xaml
    /// </summary>
    public partial class dimensi_menu : UserControl
    {
        Storyboard sb;
        MainWindow root;
        public dimensi_menu(MainWindow x)
        {
            InitializeComponent();
            root = x;
        }

        private void dim_waktu_MouseEnter(object sender, MouseEventArgs e)
        {
            sb = new Storyboard();
            sb = (Storyboard)TryFindResource("dim_waktu_enter");
            sb.Begin();
        }

        private void dim_waktu_MouseLeave(object sender, MouseEventArgs e)
        {
            sb = new Storyboard();
            sb = (Storyboard)TryFindResource("dim_waktu_leave");
            sb.Begin();
        }

        private void dim_konsumen_MouseEnter(object sender, MouseEventArgs e)
        {
            sb = new Storyboard();
            sb = (Storyboard)TryFindResource("dim_konsumen_enter");
            sb.Begin();
        }

        private void dim_konsumen_MouseLeave(object sender, MouseEventArgs e)
        {
            sb = new Storyboard();
            sb = (Storyboard)TryFindResource("dim_konsumen_leave");
            sb.Begin();
        }

        private void dim_staff_MouseEnter(object sender, MouseEventArgs e)
        {
            sb = new Storyboard();
            sb = (Storyboard)TryFindResource("dim_staff_enter");
            sb.Begin();
        }

        private void dim_staff_MouseLeave(object sender, MouseEventArgs e)
        {
            sb = new Storyboard();
            sb = (Storyboard)TryFindResource("dim_staff_leave");
            sb.Begin();
        }

        private void dim_design_MouseEnter(object sender, MouseEventArgs e)
        {
            sb = new Storyboard();
            sb = (Storyboard)TryFindResource("dim_design_enter");
            sb.Begin();
        }

        private void dim_design_MouseLeave(object sender, MouseEventArgs e)
        {
            sb = new Storyboard();
            sb = (Storyboard)TryFindResource("dim_design_leave");
            sb.Begin();
        }

        private void dim_job_MouseEnter(object sender, MouseEventArgs e)
        {
            sb = new Storyboard();
            sb = (Storyboard)TryFindResource("dim_job_enter");
            sb.Begin();
        }

        private void dim_job_MouseLeave(object sender, MouseEventArgs e)
        {
            sb = new Storyboard();
            sb = (Storyboard)TryFindResource("dim_job_leave");
            sb.Begin();
        }

        private void dim_kredit_MouseEnter(object sender, MouseEventArgs e)
        {
            sb = new Storyboard();
            sb = (Storyboard)TryFindResource("dim_kredit_enter");
            sb.Begin();
        }

        private void dim_kredit_MouseLeave(object sender, MouseEventArgs e)
        {
            sb = new Storyboard();
            sb = (Storyboard)TryFindResource("dim_kredit_leave");
            sb.Begin();
        }

        private void dim_pengiriman_MouseEnter(object sender, MouseEventArgs e)
        {
            sb = new Storyboard();
            sb = (Storyboard)TryFindResource("dim_pengirim_enter");
            sb.Begin();
        }

        private void dim_pengiriman_MouseLeave(object sender, MouseEventArgs e)
        {
            sb = new Storyboard();
            sb = (Storyboard)TryFindResource("dim_pengirim_leave");
            sb.Begin();
        }

        private void dim_produk_MouseEnter(object sender, MouseEventArgs e)
        {
            sb = new Storyboard();
            sb = (Storyboard)TryFindResource("dim_produk_enter");
            sb.Begin();
        }

        private void dim_produk_MouseLeave(object sender, MouseEventArgs e)
        {
            sb = new Storyboard();
            sb = (Storyboard)TryFindResource("dim_produk_leave");
            sb.Begin();
        }

        private void dim_size_MouseEnter(object sender, MouseEventArgs e)
        {
            sb = new Storyboard();
            sb = (Storyboard)TryFindResource("dim_size_enter");
            sb.Begin();
        }

        private void dim_size_MouseLeave(object sender, MouseEventArgs e)
        {
            sb = new Storyboard();
            sb = (Storyboard)TryFindResource("dim_size_leave");
            sb.Begin();
        }

        private void dim_menu_MouseEnter(object sender, MouseEventArgs e)
        {
            sb = new Storyboard();
            sb = (Storyboard)TryFindResource("dim_menu_enter");
            sb.Begin();
        }

        private void dim_menu_MouseLeave(object sender, MouseEventArgs e)
        {
            sb = new Storyboard();
            sb = (Storyboard)TryFindResource("dim_menu_leave");
            sb.Begin();
        }

        private void dim_menu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.uc_handle("success");
        }

        private void dim_konsumen_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.mc = new dimensi_fakta(root, "dimensi", "konsumen");
            root.content_control.Children.Clear();
            root.content_control.Children.Add(root.mc);
            root.fading();
        }

        private void dim_waktu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.mc = new dimensi_fakta(root, "dimensi", "waktu");
            root.content_control.Children.Clear();
            root.content_control.Children.Add(root.mc);
            root.fading();
        }

        private void dim_staff_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.mc = new dimensi_fakta(root, "dimensi", "staff_produksi");
            root.content_control.Children.Clear();
            root.content_control.Children.Add(root.mc);
            root.fading();
        }

        private void dim_design_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.mc = new dimensi_fakta(root, "dimensi", "design");
            root.content_control.Children.Clear();
            root.content_control.Children.Add(root.mc);
            root.fading();
        }

        private void dim_job_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.mc = new dimensi_fakta(root, "dimensi", "job");
            root.content_control.Children.Clear();
            root.content_control.Children.Add(root.mc);
            root.fading();
        }

        private void dim_kredit_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.mc = new dimensi_fakta(root, "dimensi", "kredit");
            root.content_control.Children.Clear();
            root.content_control.Children.Add(root.mc);
            root.fading();
        }

        private void dim_pengiriman_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.mc = new dimensi_fakta(root, "dimensi", "pengiriman");
            root.content_control.Children.Clear();
            root.content_control.Children.Add(root.mc);
            root.fading();
        }

        private void dim_produk_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.mc = new dimensi_fakta(root, "dimensi", "produk");
            root.content_control.Children.Clear();
            root.content_control.Children.Add(root.mc);
            root.fading();
        }

        private void dim_size_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            root.mc = new dimensi_fakta(root, "dimensi", "size");
            root.content_control.Children.Clear();
            root.content_control.Children.Add(root.mc);
            root.fading();
        }
    }
}

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
using System.Windows.Threading;

namespace app_Spaceman_Warehouse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserControl isi_content= null;
        public dimensi_fakta mc;
        public etl_load staging;
        public Storyboard x,m = new Storyboard();
        public mainmenu mn_utama;
        public olap olp;
        public MainWindow()
        {
            InitializeComponent();
            mc = new dimensi_fakta(this, "", "");
            staging = new etl_load(this);
            mn_utama = new mainmenu(this);
            olp = new olap(this,"");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            status_content.Text = "Home";
            m = (Storyboard)TryFindResource("window_open");
            m.Begin();
            isi_content = new home(this);
            content_control.Children.Add(isi_content);
            x = (Storyboard)TryFindResource("content_fading_in");
            x.Begin();
        }

        private void minimizebtn_MouseEnter(object sender, MouseEventArgs e)
        {
            ImageBrush x = new ImageBrush();
            x.ImageSource = new BitmapImage(new Uri("pack://application:,,,/app_Spaceman_Warehouse;component/Resources/minimize_-mouse_enter.png", UriKind.Absolute));
            minimizebtn.Background = x;

        }

        private void minimizebtn_MouseLeave(object sender, MouseEventArgs e)
        {
            minimizebtn.Background = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/app_Spaceman_Warehouse;component/Resources/minimize_-mouse_leave.png", UriKind.Absolute)));
        }

        private void minimizebtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Minimized;
        }

        private void maximizebtn_MouseEnter(object sender, MouseEventArgs e)
        {
            if (this.WindowState == System.Windows.WindowState.Maximized)
            {
                maximizebtn.Background = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/app_Spaceman_Warehouse;component/Resources/maximized2_mouse_enter.png", UriKind.Absolute)));
            }
            else
            {
                maximizebtn.Background = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/app_Spaceman_Warehouse;component/Resources/maximized_mouse_enter.png", UriKind.Absolute)));
            }
        }

        private void maximizebtn_MouseLeave(object sender, MouseEventArgs e)
        {
            if (this.WindowState == System.Windows.WindowState.Maximized)
            {
                maximizebtn.Background = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/app_Spaceman_Warehouse;component/Resources/maximized2_mouse_leave.png", UriKind.Absolute)));
            }
            else
            {
                maximizebtn.Background = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/app_Spaceman_Warehouse;component/Resources/maximized_mouse_leave.png", UriKind.Absolute)));
            }
        }

        private void maximizebtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            
            if (this.WindowState == System.Windows.WindowState.Maximized)
            {
               this.WindowState = System.Windows.WindowState.Normal;
               content.Width = this.Width;
               content_control.Width = content.Width;
               content.Height = this.Height - (header.Height + footer.Height)-4;
               content_control.Height = content.Height;
               if (mc.menu.Height > this.Height - (header.Height + footer.Height))
               {
                   mc.menu.Height = content_control.Height-4;
               }

               if (mc.Width > this.Width)
               {
                   content.Width = this.Width;
                   content_control.Width = content.Width;
                   mc.Width = content_control.Width;
               }
               if (olp.menu_olap.Height > this.Height - (header.Height + footer.Height))
               {
                   olp.Height = this.Height - (header.Height + footer.Height) - 4;
                   olp.menu_olap.Height = content_control.Height - 4;
                   olp.olap_content.Height = olp.menu_olap.Height - 100;
               }
               if (olp.Width > this.Width)
               {
                   content.Width = this.Width;
                   content_control.Width = content.Width;
                   olp.Width = content_control.Width;
               }
               m = (Storyboard)TryFindResource("window_open");
               m.Begin();
               x = (Storyboard)TryFindResource("content_fading_in");
               x.Begin();
               
            }
            else
            {
                this.WindowState = System.Windows.WindowState.Maximized;
                content.Width = this.Width;
                content_control.Width = content.Width;
                content.Height = this.Height - (header.Height + footer.Height)-4;
                content_control.Height = content.Height;
                if (mc.Height < this.Height - (header.Height + footer.Height))
                {
                    mc.Height = this.Height - (header.Height + footer.Height)-4;
                    mc.sub_menu.Height = this.Height - (header.Height + footer.Height)-4;
                   
                }

                if (mc.Width < this.Width)
                {
                    content.Width = this.Width;
                    content_control.Width = this.Width;
                    mc.Width = content_control.Width;
                    
                    /*mc.sub_content_header.Width = mc.Width - mc.sub_menu.Width-4;
                    mc.tabel_header.Width = mc.sub_content_header.Width-4;
                    mc.tabel_wrapper.Width = mc.sub_content_header.Width-4;
                    mc.tabel_view.Width = mc.sub_content_header.Width-4;*/
                }
                if (olp.Height < this.Height - (header.Height + footer.Height))
                {
                    olp.Height = this.Height - (header.Height + footer.Height) - 4;
                    olp.menu_olap.Height = this.Height - (header.Height + footer.Height) - 4;
                    olp.olap_content.Height = olp.menu_olap.Height - 100;
                }
                if (olp.Width < this.Width)
                {
                    content.Width = this.Width;
                    content_control.Width = this.Width;
                    olp.Width = content_control.Width;
                    
                }
                state_window_maximize();
               
                m = (Storyboard)TryFindResource("content_fading_in");
                m.Begin();
            }
        }

        private void Label_MouseEnter(object sender, MouseEventArgs e)
        {
            closebtn.Background = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/app_Spaceman_Warehouse;component/Resources/close_mouse-enter.png", UriKind.Absolute)));
        }

        private void closebtn_MouseLeave(object sender, MouseEventArgs e)
        {
            closebtn.Background = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/app_Spaceman_Warehouse;component/Resources/close_mouse_leave.png", UriKind.Absolute)));
        }

        private void closebtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        /*private void Window_StateChanged(object sender, EventArgs e)
        {
            
            if (this.WindowState == System.Windows.WindowState.Maximized)
            {
                state_window_maximize();
            }
            else
            {
                
                m = (Storyboard)TryFindResource("window_open");
                m.Begin();
            }
            x = (Storyboard)TryFindResource("content_fading_in");
            x.Begin();
        }*/

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            
            if (this.WindowState == System.Windows.WindowState.Maximized)
            {
                state_window_maximize();
            }
            else
            {
                m = (Storyboard)TryFindResource("window_open");
                m.Begin();
            }
            x = (Storyboard)TryFindResource("content_fading_in");
            x.Begin();
        }

        private void state_window_maximize()
        {
            Double x = this.Width;
            Storyboard sb = new Storyboard();
            ColorAnimation init = new ColorAnimation();
            init.To = Color.FromRgb(255, 255, 255);
            init.BeginTime = TimeSpan.FromMilliseconds(0);
            init.Duration = new Duration(TimeSpan.FromMilliseconds(0));
            Storyboard.SetTarget(init, footer);
            Storyboard.SetTargetProperty(init, new PropertyPath("(StackPanel.Background).(SolidColorBrush.Color)"));
            sb.Children.Add(init);
            DoubleAnimation ba = new DoubleAnimation();
            ba.From = 0;
            ba.To = x;
            ba.Duration = new Duration(TimeSpan.FromMilliseconds(700));
            Storyboard.SetTarget(ba, border_top_content);
            Storyboard.SetTargetProperty(ba, new PropertyPath("Width"));
            sb.Children.Add(ba);
            DoubleAnimation bb = new DoubleAnimation();
            bb.From = 0;
            bb.To = x;
            bb.Duration = new Duration(TimeSpan.FromMilliseconds(700));
            Storyboard.SetTarget(bb, border_bottom_content);
            Storyboard.SetTargetProperty(bb, new PropertyPath("Width"));
            sb.Children.Add(bb);
            ColorAnimation foot = new ColorAnimation();
            foot.From = Color.FromRgb(255,255, 255);
            foot.To = Color.FromRgb(0, 139,255);
            foot.Duration = new Duration(TimeSpan.FromMilliseconds(700));
            foot.BeginTime = TimeSpan.FromMilliseconds(700);
            Storyboard.SetTarget(foot, footer);
            Storyboard.SetTargetProperty(foot, new PropertyPath("(StackPanel.Background).(SolidColorBrush.Color)"));
            sb.Children.Add(foot);
            sb.Begin();
        }

        public void fading()
        {
            x = (Storyboard)TryFindResource("content_fading_in");
            x.Begin();
        }
        public void uc_handle(string y)
        {
            
            switch (y)
            {

                case "Proses ETL":
                    staging = new etl_load(this);
                    content_control.Children.Clear();
                    content_control.Children.Add(staging);
                    status_content.Text = "Memproses ETL";
                    x = (Storyboard)TryFindResource("content_fading_in");
                    x.Begin();
                    break;

                case "success":
                    mn_utama = new mainmenu(this);
                    content_control.Children.Clear();
                    content_control.Children.Add(mn_utama);
                    status_content.Text = "Main Menu";
                    x = (Storyboard)TryFindResource("content_fading_in");
                    x.Begin();
                    break;
                
                case "failure":
                    MessageBox.Show("proses ETL gagal", "Warning", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
                    break;

                case "dimensi":
                    mc = new dimensi_fakta(this, "dimensi", "");
                    content_control.Children.Clear();
                    content_control.Children.Add(mc);
                    status_content.Text = "Dimensi";
                    fading();
                    break;

                case "fakta":
                    mc = new dimensi_fakta(this, "fakta", "");
                    content_control.Children.Clear();
                    content_control.Children.Add(mc);
                    status_content.Text = "Fakta";
                    fading();
                    break;

                case "olap":
                    olp = new olap(this,"");
                    content_control.Children.Clear();
                    content_control.Children.Add(olp);
                    status_content.Text = "Olap";
                    
                    fading();
                    break;
            }
        }
        private void status_content_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
        }
    }
}

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

namespace spaceman_warehouse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void minimizebtn_MouseEnter(object sender, MouseEventArgs e)
        {
            minimizebtn.Source = new BitmapImage(new Uri("Resources/minimize_-mouse_enter.png",UriKind.Relative));
        }

        private void minimizebtn_MouseLeave(object sender, MouseEventArgs e)
        {
            minimizebtn.Source = new BitmapImage(new Uri("Resources/minimize_-mouse_leave.png", UriKind.Relative));
        }

        private void minimizebtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Minimized;
        }

        private void closebtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void closebtn_MouseEnter(object sender, MouseEventArgs e)
        {
            closebtn.Source = new BitmapImage(new Uri("Resources/close_mouse-enter.png", UriKind.Relative));
        }

        private void closebtn_MouseLeave(object sender, MouseEventArgs e)
        {
            closebtn.Source = new BitmapImage(new Uri("Resources/close_mouse_leave.png", UriKind.Relative));
        }

        private void maxtn_MouseEnter(object sender, MouseEventArgs e)
        {
            if (this.WindowState == System.Windows.WindowState.Normal)
            {
                maxtn.Source = new BitmapImage(new Uri("Resources/maximized_mouse_enter.png", UriKind.Relative));
            }
            else
            {
                maxtn.Source = new BitmapImage(new Uri("Resources/maximized2_mouse_enter.png", UriKind.Relative));
            }
        }

        private void maxtn_MouseLeave(object sender, MouseEventArgs e)
        {
            if (this.WindowState == System.Windows.WindowState.Normal)
            {
                maxtn.Source = new BitmapImage(new Uri("Resources/maximized_mouse_leave.png", UriKind.Relative));
            }
            else
            {
                maxtn.Source = new BitmapImage(new Uri("Resources/maximized2_mouse_leave.png", UriKind.Relative));
            }
        }

        private void maxtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (this.WindowState == System.Windows.WindowState.Normal)
            {
                this.WindowState = System.Windows.WindowState.Maximized;
                maxtn.Source = new BitmapImage(new Uri("Resources/maximized2_mouse_leave.png", UriKind.Relative));
            }
            else
            {
                this.WindowState = System.Windows.WindowState.Normal;
                maxtn.Source = new BitmapImage(new Uri("Resources/maximized_mouse_leave.png", UriKind.Relative));
            }
        }
    }
}

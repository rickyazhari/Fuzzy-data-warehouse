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

namespace Spaceman_Warehouse
{
    /// <summary>
    /// Interaction logic for header.xaml
    /// </summary>
    public partial class header : UserControl
    {
        private Window parent;
        public header(Window x)
        {
            InitializeComponent();
            parent = x;
        }

        private void Closebtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            parent.Close();   
        }

        private void minimizebtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            parent.WindowState = WindowState.Minimized;
        }

        private void minimizebtn_MouseEnter(object sender, MouseEventArgs e)
        {
            minimizebtn.Background = new SolidColorBrush(Color.FromArgb(255, 28, 86, 156));
            minimizebtn.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
        }

        private void minimizebtn_MouseLeave(object sender, MouseEventArgs e)
        {
            minimizebtn.Background = Brushes.Transparent;
            minimizebtn.Foreground = Brushes.Black;
        }

        private void Closebtn_MouseEnter(object sender, MouseEventArgs e)
        {
            Closebtn.Background = new SolidColorBrush(Color.FromArgb(255, 28, 86, 156));
            Closebtn.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
        }

        private void Closebtn_MouseLeave(object sender, MouseEventArgs e)
        {
            Closebtn.Background = Brushes.Transparent;
            Closebtn.Foreground = Brushes.Black;
        }
    }
}

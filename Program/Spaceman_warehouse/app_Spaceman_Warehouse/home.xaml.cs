﻿using System;
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

namespace Spaceman_warehouse
{
    /// <summary>
    /// Interaction logic for home.xaml
    /// </summary>
    public partial class home : UserControl
    {
       
        public home()
        {
            InitializeComponent();
        }

        private void DockPanel_MouseEnter(object sender, MouseEventArgs e)
        {
            Storyboard m = new Storyboard();
            m = (Storyboard)TryFindResource("dynamic_bording");
            m.Begin();
        }

        private void DockPanel_MouseLeave(object sender, MouseEventArgs e)
        {
            Storyboard m = new Storyboard();
            m = (Storyboard)TryFindResource("dynamic_bording_close");
            m.Begin();
        }
    }
}

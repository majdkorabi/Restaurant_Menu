using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Menu
{
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void img_MouseEnter(object sender, MouseEventArgs e)
        {
            Image img = (Image)sender;
            imgFullScale.Source = img.Source;
            popFullScale.PlacementTarget = img;
            popFullScale.Width = 150;
            popFullScale.Height = 150;
            popFullScale.IsOpen = true;
        }
        private void img_MouseLeave(object sender, MouseEventArgs e)
        {
            popFullScale.IsOpen = false;
        }
    }
}

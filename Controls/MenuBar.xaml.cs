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
using Zoo_Management.CS;

namespace Zoo_Management.Controls
{
    /// <summary>
    /// Interaction logic for MenuBar.xaml
    /// </summary>
    public partial class MenuBar : UserControl
    {

        public MenuBar()
        {
            InitializeComponent();
        }

        private void ExitClick(object sender,RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MinimizeClick(object sender,RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void MaximizeClick(object sender,RoutedEventArgs e)
        {
            if (Application.Current.MainWindow.WindowState == WindowState.Maximized)
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
                Maximize.Kind = MaterialDesignThemes.Wpf.PackIconKind.Fullscreen;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
                Maximize.Kind = MaterialDesignThemes.Wpf.PackIconKind.FullscreenExit;
            }
        }
    }
}

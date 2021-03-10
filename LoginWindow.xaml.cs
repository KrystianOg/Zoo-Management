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
using System.Windows.Shapes;

namespace Zoo_Management
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        public void BorderMouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch (InvalidOperationException) { }
        }

        private void Exit(object sender,RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ChangeType(object sender, RoutedEventArgs e)
        {
            if (LoginG.Visibility.Equals(Visibility.Visible))
            {
                LoginG.Visibility = Visibility.Hidden;
                RegisterG.Visibility = Visibility.Visible;
                btnl_Login.Visibility = Visibility.Hidden;
                btnl_Register.Visibility = Visibility.Hidden;
                btnr_Login.Visibility = Visibility.Visible;
                btnr_Register.Visibility = Visibility.Visible;
                r_email.Focus();
                windowType.Text = "Register";

            }
            else
            {
                LoginG.Visibility = Visibility.Visible;
                RegisterG.Visibility = Visibility.Hidden;
                btnl_Login.Visibility = Visibility.Visible;
                btnl_Register.Visibility = Visibility.Visible;
                btnr_Login.Visibility = Visibility.Hidden;
                btnr_Register.Visibility = Visibility.Hidden;
                l_email.Focus();
                windowType.Text = "Login";
            }
        }

        private void Login(object sender,RoutedEventArgs e)
        {
            //jesli wszystko jest ok
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void Register(object sender, RoutedEventArgs e)
        {
            //if(nie istnieje i wszystko ok)

            //else if (istnieje) 

            //else if(passy sa inne)

        }
    }
}

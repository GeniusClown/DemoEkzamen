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

namespace ToursApp
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        public AddEditPage()
        {
            InitializeComponent();
        }
        private void Enter(object sender, RoutedEventArgs e)
        {
            if (Login.Text == "admin" && UrPassword.Name == "admin1")
                Manager.MainFrame.Navigate(new Admin());

            if (Login.Text == "name" && UrPassword.Name == "123")
                Manager.MainFrame.Navigate(new User());
        }

        private void TbxShowPass_MouseUp(object sender, MouseButtonEventArgs e)
        {
            TxbPassword.Visibility = Visibility.Collapsed;
            UrPassword.Visibility = Visibility.Visible;
        }

        private void TbxShowPass_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TxbPassword.Visibility = Visibility.Visible;
            UrPassword.Visibility = Visibility.Collapsed;
            TxbPassword.Text = UrPassword.Password;
        }
    }
}

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
            if (Login.Text == "admin" && Password.Text == "admin1")
                Manager.MainFrame.Navigate(new Admin());

            if (Login.Text == "name" && Password.Text == "123")
                Manager.MainFrame.Navigate(new User());
        }
    }
}

﻿using System.Windows;
using System.Windows.Controls;
using TrackingProgressInDevEducationUI;

namespace TrackingProgressInDevEducationUI.Pages
{
    /// <summary>
    /// Логика взаимодействия для SignIn.xaml
    /// </summary>
    public partial class SignIn : Page
    {
        private MainForm _mainForm;
        public SignIn(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            MainMenu menu = new MainMenu();
            _mainForm.Content = menu;
        }
    }
}

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
using System.Windows.Shapes;

namespace IMSBeta.window
{
    /// <summary>
    /// Interaction logic for win_main.xaml
    /// </summary>
    public partial class win_main : Window
    {
        public win_main()
        {
            InitializeComponent();
        }

        private void Btn_Con_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Email : name@email.com");
        }
        private void Btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SetDimension();
        }


        private void SetDimension()
        {
            this.MaxHeight = 650;
            this.MinHeight = 650;
            this.MaxWidth = 1200;
            this.MinWidth = 1200;
        }

        private void Btn_ShowUser_Click(object sender, RoutedEventArgs e)
        {
            win_users win_Users = new win_users();
            win_Users.ShowDialog();

        }
    }///////
}///////

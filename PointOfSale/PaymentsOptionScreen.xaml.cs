﻿using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentsOptionScreen.xaml
    /// </summary>
    public partial class PaymentsOptionScreen : UserControl
    {
        /* private back end variable*/
        private Container cn;
        /* private back end variable*/
        private BleakwindBuffet.Data.Combo cc;
        public PaymentsOptionScreen(Container c, BleakwindBuffet.Data.Combo combo)
        {
            InitializeComponent();
            cc = combo;
            DataContext = cc;
            cn = c;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CancelButton(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                cn.DataContext = new Combo();
                cn.MenuSelectionComponent.Child = new View1() { Container = cn };
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ReturnToOrder(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                cn.DataContext = new Combo();
                cn.MenuSelectionComponent.Child = new ComboCutomizationScreen() { Container = cn };
            }
        }
    }
}

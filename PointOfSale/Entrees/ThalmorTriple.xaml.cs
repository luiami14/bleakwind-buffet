﻿/*
 * Author: Luis Amiel
 * Class name: ThalmorTriple.xaml.cs
 * Purpose: To implement the Thalmor into the selection
 */
using BleakwindBuffet.Data;
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
    /// Interaction logic for ThalmorTriple.xaml
    /// </summary>
    public partial class ThalmorTriple : UserControl
    {
        /* private back end variable*/
        Container cn;
        /* private back end variable*/
        private BleakwindBuffet.Data.Entrees.ThalmorTriple thalmorTriple;
        /// <summary>
        /// Displaying the thalmor in the container
        /// </summary>
        /// <param name="c">displaying the smokehouse in the container</param>
        public ThalmorTriple(Container c, BleakwindBuffet.Data.Entrees.ThalmorTriple tt)
        {
            InitializeComponent();
            thalmorTriple = tt;
            DataContext = thalmorTriple;
            cn = c;
        }
        /// <summary>
        /// This is when the user is done with their special intructions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneWithOrder(object sender, RoutedEventArgs e)
        {
            cn.MenuSelectionComponent.Child = new View1() { Container = cn };
        }
        /// <summary>
        /// This is when the user wants to cancel the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CancelButton(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                cn.DataContext = new Order();
                cn.MenuSelectionComponent.Child = new View1() { Container = cn };
            }
        }
    }
}

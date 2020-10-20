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

namespace PointOfSale.DrinksCombo
{
    /// <summary>
    /// Interaction logic for SailorSodaCombo.xaml
    /// </summary>
    public partial class SailorSodaCombo : UserControl
    {
        /* private back end variable*/
        private Container cn;
        /* private back end variable*/
        private Combo combo;
        /// <summary>
        /// property called container
        /// </summary>
        public Container Container
        {
            get
            {
                return cn;
            }
            set
            {
                cn = value;
            }
        }
        /// <summary>
        /// property called combo
        /// </summary>
        public Combo Combo
        {
            get
            {
                return combo;
            }
            set
            {
                combo = value;
                DataContext = (BleakwindBuffet.Data.Drinks.SailorSoda)combo.Drink;
            }
        }
        /// <summary>
        /// Displaying the soda in the container
        /// </summary>
        /// <param name="c">displaying the soda in the container</param>
        public SailorSodaCombo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Allows the DataContext's Size property to be updated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ChangedSize(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.Drinks.SailorSoda aj)
            {
                if ((bool)smallSize.IsChecked)
                {
                    aj.Size = BleakwindBuffet.Data.Enums.Size.Small;
                }
                else if ((bool)mediumSize.IsChecked)
                {
                    aj.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                }
                else if ((bool)largeSize.IsChecked)
                {
                    aj.Size = BleakwindBuffet.Data.Enums.Size.Large;
                }
            }
        }
        /// <summary>
        /// Allows the DataContext's Size property to be updated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ChangedFlavor(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.Drinks.SailorSoda aj)
            {
                if ((bool)blackberry.IsChecked)
                {
                    aj.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Blackberry;
                }
                else if ((bool)cherry.IsChecked)
                {
                    aj.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Cherry;
                }
                else if ((bool)grapefruit.IsChecked)
                {
                    aj.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Grapefruit;
                }
                else if ((bool)lemon.IsChecked)
                {
                    aj.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Lemon;
                }
                else if ((bool)peach.IsChecked)
                {
                    aj.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Peach;
                }
                else if ((bool)watermelon.IsChecked)
                {
                    aj.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Watermelon;
                }
            }
        }
        /// <summary>
        /// This is when the user is done with their special intructions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneWithOrder(object sender, RoutedEventArgs e)
        {
            cn.MenuSelectionComponent.Child = new ComboCutomizationScreen() { Container = cn };
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

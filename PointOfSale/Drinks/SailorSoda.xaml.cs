/*
 * Author: Luis Amiel
 * Class name: SailorSoda.xaml.cs
 * Purpose: To implement the Soda into the selection
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
    /// Interaction logic for SailorSoda.xaml
    /// </summary>
    public partial class SailorSoda : UserControl
    {
        /* private back end variable*/
        Container cn;
        /* private back end variable*/
        private BleakwindBuffet.Data.Drinks.SailorSoda sailorSoda;
        /// <summary>
        /// Displaying the soda in the container
        /// </summary>
        /// <param name="c">displaying the soda in the container</param>
        public SailorSoda(Container c)
        {
            InitializeComponent();
            sailorSoda = new BleakwindBuffet.Data.Drinks.SailorSoda();
            if (c.DataContext is Order order)
            {
                order.Add(sailorSoda);

            }
            DataContext = sailorSoda;
            cn = c;
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
            cn.MenuSelectionComponent.Child = new View1() { Container = cn };
        }
    }
}

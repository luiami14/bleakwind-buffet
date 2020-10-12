/*
 * Author: Luis Amiel
 * Class name: CandlehearthCoffee.xaml.cs
 * Purpose: To implement the Coffee into the selection
 */

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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CandleheartCoffee.xaml
    /// </summary>
    public partial class CandlehearthCoffee : UserControl
    {
        /* private back end variable*/
        private Container cn;
        /* private back end variable*/
        private BleakwindBuffet.Data.Drinks.CandlehearthCoffee candleHearthCofee;
        /// <summary>
        /// Displaying the coffee in the container
        /// </summary>
        /// <param name="c">displaying the coffee in the container</param>
        public CandlehearthCoffee(Container c)
        {
            InitializeComponent();
            candleHearthCofee = new BleakwindBuffet.Data.Drinks.CandlehearthCoffee();
            if (c.DataContext is Order order)
            {
                order.Add(candleHearthCofee);

            }
            DataContext = candleHearthCofee;
            cn = c;
        }
        /// <summary>
        /// Allows the DataContext's Size property to be updated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ChangedSize(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.Drinks.CandlehearthCoffee aj)
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

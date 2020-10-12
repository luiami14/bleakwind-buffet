/*
 * Author: Luis Amiel
 * Class name: WarriorWater.xaml.cs
 * Purpose: To implement the water into the selection
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
    /// Interaction logic for WarriorWater.xaml
    /// </summary>
    public partial class WarriorWater : UserControl
    {
        /* private back end variable*/
        Container cn;
        /* private back end variable*/
        private BleakwindBuffet.Data.Drinks.WarriorWater warriorWater;
        /// <summary>
        /// Displaying the water in the container
        /// </summary>
        /// <param name="c">displaying the water in the container</param>
        public WarriorWater(Container c)
        {
            InitializeComponent();
            warriorWater = new BleakwindBuffet.Data.Drinks.WarriorWater();
            if (c.DataContext is Order order)
            {
                order.Add(warriorWater);

            }
            DataContext = warriorWater;
            cn = c;
        }
        /// <summary>
        /// Allows the DataContext's Size property to be updated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ChangedSize(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.Drinks.WarriorWater aj)
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

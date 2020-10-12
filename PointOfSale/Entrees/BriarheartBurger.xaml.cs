/*
 * Author: Luis Amiel
 * Class name: BriarheartBurger.xaml.cs
 * Purpose: To implement the burger into the selection
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
    /// Interaction logic for View2.xaml
    /// </summary>
    public partial class BriarheartBurger : UserControl
    {
        /* private back end variable*/
        Container cn;
        /* private back end variable*/
        private BleakwindBuffet.Data.Entrees.BriarheartBurger briarheartBurger;
        /// <summary>
        /// Displaying the burger in the container
        /// </summary>
        /// <param name="c">displaying the water in the container</param>
        public BriarheartBurger(Container c)
        {
            InitializeComponent();
            briarheartBurger = new BleakwindBuffet.Data.Entrees.BriarheartBurger();
            if(c.DataContext is Order order)
            {
                order.Add(briarheartBurger);
                
            }
            DataContext = briarheartBurger;
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
    }
}

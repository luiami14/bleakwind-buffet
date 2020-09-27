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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CandleheartCoffee.xaml
    /// </summary>
    public partial class CandlehearthCoffee : UserControl
    {
        /* private back end variable*/
        Container cn;
        /// <summary>
        /// Displaying the coffee in the container
        /// </summary>
        /// <param name="c">displaying the coffee in the container</param>
        public CandlehearthCoffee(Container c)
        {
            InitializeComponent();
            cn = c;
        }
        /// <summary>
        /// This is when the user is done with their special intructions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneWithOrder(object sender, RoutedEventArgs e)
        {
            cn.MenuSelectionComponent.Child = new View1(cn);
        }
    }
}

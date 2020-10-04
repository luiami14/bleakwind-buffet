/*
 * Author: Luis Amiel
 * Class name: DoubleDraugr.xaml.cs
 * Purpose: To implement the Draugr into the selection
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
    /// Interaction logic for DoubleDraugr.xaml
    /// </summary>
    public partial class DoubleDraugr : UserControl
    {
        /* private back end variable*/
        Container cn;
        /* private back end variable*/
        private BleakwindBuffet.Data.Entrees.DoubleDraugr doubleDraugr;
        /// <summary>
        /// Displaying the Draugr in the container
        /// </summary>
        /// <param name="c">displaying the Draugr in the container</param>
        public DoubleDraugr(Container c)
        {
            InitializeComponent();
            doubleDraugr = new BleakwindBuffet.Data.Entrees.DoubleDraugr();
            DataContext = doubleDraugr;
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

/*
 * Author: Luis Amiel
 * Class name: SmokehouseSkeleton.xaml.cs
 * Purpose: To implement the Smokehouse into the selection
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
    /// Interaction logic for SmokehouseSkeleton.xaml
    /// </summary>
    public partial class SmokehouseSkeleton : UserControl
    {
        /* private back end variable*/
        Container cn;
        /* private back end variable*/
        private BleakwindBuffet.Data.Entrees.SmokehouseSkeleton smokehouseSkeleton;
        /// <summary>
        /// Displaying the smokehouse in the container
        /// </summary>
        /// <param name="c">displaying the smokehouse in the container</param>
        public SmokehouseSkeleton(Container c)
        {
            InitializeComponent();
            smokehouseSkeleton = new BleakwindBuffet.Data.Entrees.SmokehouseSkeleton();
            DataContext = smokehouseSkeleton;
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

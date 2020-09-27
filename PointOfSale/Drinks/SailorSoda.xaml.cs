/*
 * Author: Luis Amiel
 * Class name: SailorSoda.xaml.cs
 * Purpose: To implement the Soda into the selection
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
    /// Interaction logic for SailorSoda.xaml
    /// </summary>
    public partial class SailorSoda : UserControl
    {
        /* private back end variable*/
        Container cn;
        /// <summary>
        /// Displaying the soda in the container
        /// </summary>
        /// <param name="c">displaying the soda in the container</param>
        public SailorSoda(Container c)
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

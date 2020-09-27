/*
 * Author: Luis Amiel
 * Class name: PhillyPoacher.xaml.cs
 * Purpose: To implement the poacher into the selection
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
    /// Interaction logic for PhillyPoacher.xaml
    /// </summary>
    public partial class PhillyPoacher : UserControl
    {
        /* private back end variable*/
        Container cn;
        /// <summary>
        /// Displaying the poacher in the container
        /// </summary>
        /// <param name="c">displaying the poacher in the container</param>
        public PhillyPoacher(Container c)
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

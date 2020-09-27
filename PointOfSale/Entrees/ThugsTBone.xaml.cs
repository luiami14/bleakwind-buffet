/*
 * Author: Luis Amiel
 * Class name: ThugsTBone.xaml.cs
 * Purpose: To implement the TBone into the selection
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
    /// Interaction logic for ThugsTBone.xaml
    /// </summary>
    public partial class ThugsTBone : UserControl
    {
        /* private back end variable*/
        Container cn;
        /// <summary>
        /// Displaying the TBone in the container
        /// </summary>
        /// <param name="c">displaying the TBone in the container</param>
        public ThugsTBone(Container c)
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

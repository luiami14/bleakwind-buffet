/*
 * Author: Luis Amiel
 * Class name: AretinoAppleJuice.xaml.cs
 * Purpose: To implement the applce juice into the selection
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
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for AretinoAppleJuice.xaml
    /// </summary>
    public partial class AretinoAppleJuice : UserControl
    {
        /* private back end variable*/
        private Container cn;
        /* private back end variable*/
        private AretinoAppleJuice appleJuice;
        /// <summary>
        /// Displaying the juice in the container
        /// </summary>
        /// <param name="c">displaying the juice in the container</param>
        public AretinoAppleJuice(Container c)
        {
            InitializeComponent();
            appleJuice = new AretinoAppleJuice();
            DataContext = appleJuice;
            cn = c;
        }
        public void ChangedSize(object sender, RoutedEventArgs e)
        {
            if(DataContext is AretinoAppleJuice aj)
            {
                if((bool)smallSize.IsChecked)
                {
                    aj.SizeChanged = Data.Emuns.Size.Small;
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
            cn.MenuSelectionComponent.Child = new View1(cn);
        }
    }
}

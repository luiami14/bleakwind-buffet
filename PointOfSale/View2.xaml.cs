/*
 * Author: Luis Amiel
 * Class name: View1.xaml.cs
 * Purpose: The purpose of this class was implement another screen onto the main screen
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
    /// Interaction logic for View2.xaml
    /// </summary>
    public partial class View2 : UserControl
    {
        /* private back end variable*/
        private Container cn;
        public Container Container
        {
            get
            {
                return cn;
            }
            set
            {
                cn = value;
            }
        }

        /// <summary>
        /// This View2 is the second view
        /// </summary>
        /// <param name="c">displaying the view in the container</param>
        public View2()
        {
            InitializeComponent();
        }
    }
}

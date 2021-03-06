﻿/*
 * Author: Luis Amiel
 * Class name: Container.xaml.cs
 * Purpose: This class is for the implementations of both views
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
    /// Interaction logic for Container.xaml
    /// </summary>
    public partial class Container : UserControl
    {
        /// <summary>
        /// This contains both views that I implemented into the GUI
        /// </summary>
        public Container()
        {
            InitializeComponent();
            vw.Container = this;           
            vq.Container = this;
            DataContext = new Order();
        }
    }
}

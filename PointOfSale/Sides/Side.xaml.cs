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

namespace PointOfSale.Sides
{
    /// <summary>
    /// Interaction logic for Side.xaml
    /// </summary>
    public partial class Side : UserControl
    {
        /* private back end variable*/
        private Container cn;
        /* private back end variable*/
        private Combo combo;
        /// <summary>
        /// 
        /// </summary>
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
        public Combo Combo
        {
            get
            {
                return combo;
            }
            set
            {
                combo = value;
                DataContext = combo;
            }
        }
        public Side()
        {
            InitializeComponent();
        }
        void CompleteButton(object sender, RoutedEventArgs e)
        {
            cn.MenuSelectionComponent.Child = new PaymentsOptionScreen() { Container = cn };
        }

        void CancelButton(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                cn.DataContext = new Combo();
                cn.MenuSelectionComponent.Child = new View1() { Container = cn };
            }
        }

        void DoneWithOrder(object sender, RoutedEventArgs e)
        {
            cn.MenuSelectionComponent.Child = new View1() { Container = cn };
        }
    }
}

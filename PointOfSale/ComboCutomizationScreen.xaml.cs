using BleakwindBuffet.Data;
using PointOfSale.Drinks;
using PointOfSale.Entrees;
using PointOfSale.Sides;
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
    /// Interaction logic for ComboCutomizationScreen.xaml
    /// </summary>
    public partial class ComboCutomizationScreen : UserControl
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
        /* private back end variable*/
        private BleakwindBuffet.Data.Combo cc;
        public ComboCutomizationScreen()
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
                Container.DataContext = new Order();
                cn.MenuSelectionComponent.Child = new View1() { Container = cn };
            }
        }

        void DoneWithOrder(object sender, RoutedEventArgs e)
        {
            cn.MenuSelectionComponent.Child = new View1() { Container = cn };
        }

        void EntreeButton(object sender, RoutedEventArgs e)
        {
            cn.MenuSelectionComponent.Child = new Entree() { Container = cn, Combo = combo };
        }

        void DrinkButton(object sender, RoutedEventArgs e)
        {
            cn.MenuSelectionComponent.Child = new Drink() { Container = cn, Combo = combo };
        }

        void SideButton(object sender, RoutedEventArgs e)
        {
            cn.MenuSelectionComponent.Child = new Side() { Container = cn, Combo = combo };
        }
    }
}

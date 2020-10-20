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
        /// Property called Container
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
        /// <summary>
        /// Property called combo
        /// </summary>
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
        /// <summary>
        /// This is the constructor
        /// </summary>
        public ComboCutomizationScreen()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This button is when the suer is ready to complete the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CompleteButton(object sender, RoutedEventArgs e)
        {
            cn.MenuSelectionComponent.Child = new PaymentsOptionScreen() { Container = cn };
        }
        /// <summary>
        /// This button is when the user wants to cancel the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CancelButton(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                cn.DataContext = new Combo();
                Container.DataContext = new Order();
                cn.MenuSelectionComponent.Child = new View1() { Container = cn };
            }
        }
        /// <summary>
        /// This button is when the user is done choosing the order and it goes back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneWithOrder(object sender, RoutedEventArgs e)
        {
            cn.MenuSelectionComponent.Child = new View1() { Container = cn };
        }
        /// <summary>
        /// This button is when the user wants to change something in the entrees
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void EntreeButton(object sender, RoutedEventArgs e)
        {
            cn.MenuSelectionComponent.Child = new Entree() { Container = cn, Combo = combo };
        }
        /// <summary>
        /// This button is when the user wants to change something in the drinks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DrinkButton(object sender, RoutedEventArgs e)
        {
            cn.MenuSelectionComponent.Child = new Drink() { Container = cn, Combo = combo };
        }
        /// <summary>
        /// This button is when the user wants to change something in the sides
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SideButton(object sender, RoutedEventArgs e)
        {
            cn.MenuSelectionComponent.Child = new Side() { Container = cn, Combo = combo };
        }
    }
}

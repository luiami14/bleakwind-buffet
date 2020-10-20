using BleakwindBuffet.Data;
using PointOfSale.DrinksCombo;
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

namespace PointOfSale.Drinks
{
    /// <summary>
    /// Interaction logic for Drink.xaml
    /// </summary>
    public partial class Drink : UserControl
    {
        /* private back end variable*/
        private Container cn;
        /* private back end variable*/
        private Combo combo;
        /// <summary>
        /// Property called container
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
        /// Property caleed combo
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
        /// <summary>
        /// this is the cunstructor
        /// </summary>
        public Drink()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This button is when the user is complete with the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CompleteButton(object sender, RoutedEventArgs e)
        {
            cn.MenuSelectionComponent.Child = new PaymentsOptionScreen() { Container = cn };
        }
        /// <summary>
        /// This button is when the uder wants to cancel the order
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
        /// This button is called when the uder is done with the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneWithOrder(object sender, RoutedEventArgs e)
        {
            cn.MenuSelectionComponent.Child = new ComboCutomizationScreen() { Container = cn };
        }
        /// <summary>
        /// This is called when the user wants to change the drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AretinoAppleJuiceCombo(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            if (DataContext is Combo order)
            {
                if (bt.Name == "AretinoAppleJuice")
                {
                    BleakwindBuffet.Data.Drinks.AretinoAppleJuice burger = new BleakwindBuffet.Data.Drinks.AretinoAppleJuice();
                    order.Drink = burger;
                    cn.MenuSelectionComponent.Child = new AretinoAppleJuiceCombo() { Container = cn, Combo = combo };
                }
            }
        }
        /// <summary>
        /// This is called when the user wants to change the drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CandlehearthCoffeeCombo(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            if (DataContext is Combo order)
            {
                if (bt.Name == "CandlehearthCoffee")
                {
                    BleakwindBuffet.Data.Drinks.CandlehearthCoffee burger = new BleakwindBuffet.Data.Drinks.CandlehearthCoffee();
                    order.Drink = burger;
                    cn.MenuSelectionComponent.Child = new CandlehearthCoffeeCombo() { Container = cn, Combo = combo};
                }
            }
        }
        /// <summary>
        /// This is called when the user wants to change the drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MarkathMilkCombo(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            if (DataContext is Combo order)
            {
                if (bt.Name == "MarkathMilk")
                {
                    BleakwindBuffet.Data.Drinks.MarkarthMilk burger = new BleakwindBuffet.Data.Drinks.MarkarthMilk();
                    order.Drink = burger;
                    cn.MenuSelectionComponent.Child = new MarkathMilkCombo() { Container = cn , Combo = combo};
                }
            }
        }
        /// <summary>
        /// This is called when the user wants to change the drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SailorSodaCombo(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            if (DataContext is Combo order)
            {
                if (bt.Name == "SailorSoda")
                {
                    BleakwindBuffet.Data.Drinks.SailorSoda burger = new BleakwindBuffet.Data.Drinks.SailorSoda();
                    order.Drink = burger;
                    cn.MenuSelectionComponent.Child = new SailorSodaCombo() { Container = cn, Combo = combo };
                }
            }
        }
        /// <summary>
        /// This is called when the user wants to change the drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void WarriorWaterCombo(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            if (DataContext is Combo order)
            {
                if (bt.Name == "WarriorWater")
                {
                    BleakwindBuffet.Data.Drinks.WarriorWater burger = new BleakwindBuffet.Data.Drinks.WarriorWater();
                    order.Drink = burger;
                    cn.MenuSelectionComponent.Child = new WarriorWaterCombo() { Container = cn , Combo = combo};
                }
            }
        }
    }
}

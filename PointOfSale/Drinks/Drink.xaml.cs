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
        public Drink()
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

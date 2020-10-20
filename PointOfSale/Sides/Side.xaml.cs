using BleakwindBuffet.Data;
using PointOfSale.SidesCombo;
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
        /// A property called Container
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
        /// A property called combo
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
        /// This is the constructor
        /// </summary>
        public Side()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This button is when the user wants to complete the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CompleteButton(object sender, RoutedEventArgs e)
        {
            cn.MenuSelectionComponent.Child = new PaymentsOptionScreen() { Container = cn };
        }
        /// <summary>
        /// this button is when the user is want to cancel the order
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
        /// This button is when the user is done with the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneWithOrder(object sender, RoutedEventArgs e)
        {
            cn.MenuSelectionComponent.Child = new ComboCutomizationScreen() { Container = cn };
        }
        /// <summary>
        /// This button is when the user picks the fries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DragonbornWaffleFriesCombo(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            if (DataContext is Combo order)
            {
                if (bt.Name == "DragonbornWaffleFries")
                {
                    BleakwindBuffet.Data.Sides.DragonbornWaffleFries burger = new BleakwindBuffet.Data.Sides.DragonbornWaffleFries();
                    order.Side = burger;
                    cn.MenuSelectionComponent.Child = new DragonbornWaffleFriesCombo() { Container = cn , Combo = combo};
                }
            }
        }
        /// <summary>
        /// This button is when the user picks the fried mirrak
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FriedMiraakCombo(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            if (DataContext is Combo  order)
            {
                if (bt.Name == "FriedMiraak")
                {
                    BleakwindBuffet.Data.Sides.FriedMiraak burger = new BleakwindBuffet.Data.Sides.FriedMiraak();
                    order.Side = burger;
                    cn.MenuSelectionComponent.Child = new FriedMiraakCombo() { Container = cn, Combo =combo };
                }
            }
        }
        /// <summary>
        /// This is when the user picks the Otar grits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MadOtarGritsCombo(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            if (DataContext is Combo order)
            {
                if (bt.Name == "MadOtarGrits")
                {
                    BleakwindBuffet.Data.Sides.MadOtarGrits burger = new BleakwindBuffet.Data.Sides.MadOtarGrits();
                    order.Side = burger;
                    cn.MenuSelectionComponent.Child = new MadOtarGritsCombo() { Container = cn, Combo = combo};
                }
            }
        }
        /// <summary>
        /// This is when the user clicks on the vokun salad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void VokunSaladCombo(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            if (DataContext is Combo order)
            {
                if (bt.Name == "VokunSalad")
                {
                    BleakwindBuffet.Data.Sides.VokunSalad burger = new BleakwindBuffet.Data.Sides.VokunSalad();
                    order.Side = burger;
                    cn.MenuSelectionComponent.Child = new VokunSaladCombo() { Container = cn , Combo =combo};
                }
            }
        }
    }
}

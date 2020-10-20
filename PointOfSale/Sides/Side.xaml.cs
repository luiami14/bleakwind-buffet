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
                Container.DataContext = new Order();
                cn.MenuSelectionComponent.Child = new View1() { Container = cn };
            }
        }

        void DoneWithOrder(object sender, RoutedEventArgs e)
        {
            cn.MenuSelectionComponent.Child = new ComboCutomizationScreen() { Container = cn };
        }

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

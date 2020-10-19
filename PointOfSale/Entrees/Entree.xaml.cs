using BleakwindBuffet.Data;
using PointOfSale.EntreesCombo;
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

namespace PointOfSale.Entrees
{
    /// <summary>
    /// Interaction logic for Entree.xaml
    /// </summary>
    public partial class Entree : UserControl
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
        public Entree()
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

        void BriarheartBurgerCombo(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            if (DataContext is Combo order)
            {
                if (bt.Name == "BriarheartBurger")
                {
                    BleakwindBuffet.Data.Entrees.BriarheartBurger burger = new BleakwindBuffet.Data.Entrees.BriarheartBurger();
                    order.Entree = burger;
                    cn.MenuSelectionComponent.Child = new BriarheartBurgerCombo() { Container = cn, Combo = combo };
                }
            }
        }

        void DoubleDraugrCombo(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            if (DataContext is Combo order)
            {
                if (bt.Name == "DoubleDraugr")
                {
                    BleakwindBuffet.Data.Entrees.DoubleDraugr burger = new BleakwindBuffet.Data.Entrees.DoubleDraugr();
                    order.Entree = burger;
                    cn.MenuSelectionComponent.Child = new DoubleDraugrCombo() { Container = cn, Combo = combo };
                }
            }
        }

        void GardenOrcOmeletteCombo(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            if (DataContext is Combo order)
            {
                if (bt.Name == "GardenOrcOmelette")
                {
                    BleakwindBuffet.Data.Entrees.GardenOrcOmelette burger = new BleakwindBuffet.Data.Entrees.GardenOrcOmelette();
                    order.Entree = burger;
                    cn.MenuSelectionComponent.Child = new GardenOrcOmeletteCombo() { Container = cn, Combo = combo };
                }
            }
        }

        void PhillyPoacherCombo(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            if (DataContext is Combo order)
            {
                if (bt.Name == "PhillyPoacher")
                {
                    BleakwindBuffet.Data.Entrees.PhillyPoacher burger = new BleakwindBuffet.Data.Entrees.PhillyPoacher();
                    order.Entree = burger;
                    cn.MenuSelectionComponent.Child = new PhillyPoacherCombo() { Container = cn, Combo = combo };
                }
            }
        }

        void SmokehouseSkeletonCombo(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            if (DataContext is Combo order)
            {
                if (bt.Name == "SmokehouseSkeleton")
                {
                    BleakwindBuffet.Data.Entrees.SmokehouseSkeleton burger = new BleakwindBuffet.Data.Entrees.SmokehouseSkeleton();
                    order.Entree = burger;
                    cn.MenuSelectionComponent.Child = new SmokehouseSkeletonCombo() { Container = cn, Combo = combo};
                }
            }
        }

        void ThalmorTripleCombo(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            if (DataContext is Combo order)
            {
                if (bt.Name == "ThalmorTriple")
                {
                    BleakwindBuffet.Data.Entrees.ThalmorTriple burger = new BleakwindBuffet.Data.Entrees.ThalmorTriple();
                    order.Entree = burger;
                    cn.MenuSelectionComponent.Child = new ThalmorTripleCombo() { Container = cn, Combo = combo };
                }
            }
        }

        void ThugsTBoneCombo(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            if (DataContext is Combo order)
            {
                if (bt.Name == "ThugsTBone")
                {
                    BleakwindBuffet.Data.Entrees.ThugsTBone burger = new BleakwindBuffet.Data.Entrees.ThugsTBone();
                    order.Entree = burger;
                    cn.MenuSelectionComponent.Child = new ThugsTBoneCombo() { Container = cn, Combo = combo };
                }
            }
        }
    }
}

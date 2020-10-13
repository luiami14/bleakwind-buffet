/*
 * Author: Luis Amiel
 * Class name: View1.xaml.cs
 * Purpose: The purpose of this class was implement the clicks of buttons
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Interface;
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
    /// Interaction logic for View1.xaml
    /// </summary>
    public partial class View1 : UserControl
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
        /// This View1 is the starting view of the menu
        /// </summary>
        /// <param name="c">displaying the view in the container</param>
        public View1()
        {
            InitializeComponent();
        }

        void CancelButton(object sender, RoutedEventArgs e)
        {
            
                if (sender is Button button)
                {
                Container.DataContext = new Order();
                }
        }
        /// <summary>
        /// This method selects every button that can be clicked in View1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClicksButton(object sender, RoutedEventArgs e)
        {
            Button bt = (Button) sender;
            if(DataContext is Order order)
            {
                if (bt.Name == "BriarheartBurger")
                {
                    BleakwindBuffet.Data.Entrees.BriarheartBurger burger = new BleakwindBuffet.Data.Entrees.BriarheartBurger();
                    order.Add(burger);
                    cn.MenuSelectionComponent.Child = new BriarheartBurger(cn, burger);
                }
                else if (bt.Name == "AretinoAppleJuice")
                {
                    BleakwindBuffet.Data.Drinks.AretinoAppleJuice aj = new BleakwindBuffet.Data.Drinks.AretinoAppleJuice();
                    order.Add(aj);
                    cn.MenuSelectionComponent.Child = new AretinoAppleJuice(cn, aj);
                }
                else if (bt.Name == "CandlehearthCoffee")
                {
                    BleakwindBuffet.Data.Drinks.CandlehearthCoffee cc = new BleakwindBuffet.Data.Drinks.CandlehearthCoffee();
                    order.Add(cc);
                    cn.MenuSelectionComponent.Child = new CandlehearthCoffee(cn, cc);
                }
                else if (bt.Name == "DoubleDraugr")
                {
                    BleakwindBuffet.Data.Entrees.DoubleDraugr dd = new BleakwindBuffet.Data.Entrees.DoubleDraugr();
                    order.Add(dd);
                    cn.MenuSelectionComponent.Child = new DoubleDraugr(cn, dd);
                }
                else if (bt.Name == "DragonbornWaffleFries")
                {
                    BleakwindBuffet.Data.Sides.DragonbornWaffleFries df = new BleakwindBuffet.Data.Sides.DragonbornWaffleFries();
                    order.Add(df);
                    cn.MenuSelectionComponent.Child = new DragonbornWaffleFries(cn, df);
                }
                else if (bt.Name == "FriedMiraak")
                {
                    BleakwindBuffet.Data.Sides.FriedMiraak fm = new BleakwindBuffet.Data.Sides.FriedMiraak();
                    order.Add(fm);
                    cn.MenuSelectionComponent.Child = new FriedMiraak(cn, fm);
                }
                else if (bt.Name == "GardenOrcOmelette")
                {
                    BleakwindBuffet.Data.Entrees.GardenOrcOmelette go = new BleakwindBuffet.Data.Entrees.GardenOrcOmelette();
                    order.Add(go);
                    cn.MenuSelectionComponent.Child = new GardenOrcOmelette(cn, go);
                }
                else if (bt.Name == "MadOtarGrits")
                {
                    BleakwindBuffet.Data.Sides.MadOtarGrits mg = new BleakwindBuffet.Data.Sides.MadOtarGrits();
                    order.Add(mg);
                    cn.MenuSelectionComponent.Child = new MadOtarGrits(cn, mg);
                }
                else if (bt.Name == "MarkathMilk")
                {
                    BleakwindBuffet.Data.Drinks.MarkarthMilk mm = new BleakwindBuffet.Data.Drinks.MarkarthMilk();
                    order.Add(mm);
                    cn.MenuSelectionComponent.Child = new MarkathMilk(cn, mm);
                }
                else if (bt.Name == "PhillyPoacher")
                {
                    BleakwindBuffet.Data.Entrees.PhillyPoacher pp = new BleakwindBuffet.Data.Entrees.PhillyPoacher();
                    order.Add(pp);
                    cn.MenuSelectionComponent.Child = new PhillyPoacher(cn, pp);
                }
                else if (bt.Name == "SailorSoda")
                {
                    BleakwindBuffet.Data.Drinks.SailorSoda ss = new BleakwindBuffet.Data.Drinks.SailorSoda();
                    order.Add(ss);
                    cn.MenuSelectionComponent.Child = new SailorSoda(cn, ss);
                }
                else if (bt.Name == "SmokehouseSkeleton")
                {
                    BleakwindBuffet.Data.Entrees.SmokehouseSkeleton sm = new BleakwindBuffet.Data.Entrees.SmokehouseSkeleton();
                    order.Add(sm);
                    cn.MenuSelectionComponent.Child = new SmokehouseSkeleton(cn, sm);
                }
                else if (bt.Name == "ThalmorTriple")
                {
                    BleakwindBuffet.Data.Entrees.ThalmorTriple tt = new BleakwindBuffet.Data.Entrees.ThalmorTriple();
                    order.Add(tt);
                    cn.MenuSelectionComponent.Child = new ThalmorTriple(cn, tt);
                }
                else if (bt.Name == "ThugsTBone")
                {
                    BleakwindBuffet.Data.Entrees.ThugsTBone tb = new BleakwindBuffet.Data.Entrees.ThugsTBone();
                    order.Add(tb);
                    cn.MenuSelectionComponent.Child = new ThugsTBone(cn, tb);
                }
                else if (bt.Name == "VokunSalad")
                {
                    BleakwindBuffet.Data.Sides.VokunSalad vs = new BleakwindBuffet.Data.Sides.VokunSalad();
                    order.Add(vs);
                    cn.MenuSelectionComponent.Child = new VokunSalad(cn, vs);
                }
                else if (bt.Name == "WarriorWater")
                {
                    BleakwindBuffet.Data.Drinks.WarriorWater ww = new BleakwindBuffet.Data.Drinks.WarriorWater();
                    order.Add(ww);
                    cn.MenuSelectionComponent.Child = new WarriorWater(cn, ww);
                }
            }
        }
    }
}

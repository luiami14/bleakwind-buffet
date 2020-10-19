/*
 * Author: Luis Amiel
 * Class name: View1.xaml.cs
 * Purpose: The purpose of this class was implement another screen onto the main screen
 */
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Interface;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for View2.xaml
    /// </summary>
    public partial class View2 : UserControl
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
        /// This View2 is the second view
        /// </summary>
        /// <param name="c">displaying the view in the container</param>
        public View2()
        {
            InitializeComponent();
        }
        private void UpdateItem(object sender, SelectionChangedEventArgs e)
        {
            if(sender is ListView list)
            {
                if (list.SelectedItem is BleakwindBuffet.Data.Entrees.BriarheartBurger bb) cn.MenuSelectionComponent.Child = new BriarheartBurger(cn, bb);
                else if (list.SelectedItem is BleakwindBuffet.Data.Drinks.AretinoAppleJuice aj) cn.MenuSelectionComponent.Child = new AretinoAppleJuice(cn, aj);
                else if (list.SelectedItem is BleakwindBuffet.Data.Drinks.CandlehearthCoffee cc) cn.MenuSelectionComponent.Child = new CandlehearthCoffee(cn, cc);
                else if (list.SelectedItem is BleakwindBuffet.Data.Entrees.DoubleDraugr dd) cn.MenuSelectionComponent.Child = new DoubleDraugr(cn, dd);
                else if (list.SelectedItem is BleakwindBuffet.Data.Sides.DragonbornWaffleFries dw) cn.MenuSelectionComponent.Child = new DragonbornWaffleFries(cn, dw);
                else if (list.SelectedItem is BleakwindBuffet.Data.Sides.FriedMiraak fm) cn.MenuSelectionComponent.Child = new FriedMiraak(cn, fm);
                else if (list.SelectedItem is BleakwindBuffet.Data.Entrees.GardenOrcOmelette go) cn.MenuSelectionComponent.Child = new GardenOrcOmelette(cn, go);
                else if (list.SelectedItem is BleakwindBuffet.Data.Sides.MadOtarGrits mo) cn.MenuSelectionComponent.Child = new MadOtarGrits(cn, mo);
                else if (list.SelectedItem is BleakwindBuffet.Data.Drinks.MarkarthMilk mm) cn.MenuSelectionComponent.Child = new MarkathMilk(cn, mm);
                else if (list.SelectedItem is BleakwindBuffet.Data.Entrees.PhillyPoacher pp) cn.MenuSelectionComponent.Child = new PhillyPoacher(cn, pp);
                else if (list.SelectedItem is BleakwindBuffet.Data.Drinks.SailorSoda ss) cn.MenuSelectionComponent.Child = new SailorSoda(cn, ss);
                else if (list.SelectedItem is BleakwindBuffet.Data.Entrees.SmokehouseSkeleton sj) cn.MenuSelectionComponent.Child = new SmokehouseSkeleton(cn, sj);
                else if (list.SelectedItem is BleakwindBuffet.Data.Entrees.ThalmorTriple tt) cn.MenuSelectionComponent.Child = new ThalmorTriple(cn, tt);
                else if (list.SelectedItem is BleakwindBuffet.Data.Entrees.ThugsTBone tb) cn.MenuSelectionComponent.Child = new ThugsTBone(cn, tb);
                else if (list.SelectedItem is BleakwindBuffet.Data.Sides.VokunSalad vk) cn.MenuSelectionComponent.Child = new VokunSalad(cn, vk);
                else if (list.SelectedItem is BleakwindBuffet.Data.Drinks.WarriorWater ww) cn.MenuSelectionComponent.Child = new WarriorWater(cn, ww);
            }
        }
        void RemoveItem(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                if(sender is Button button)
                {
                    order.Remove((IOrderItem)button.DataContext);
                }
            }
        }
    }
}

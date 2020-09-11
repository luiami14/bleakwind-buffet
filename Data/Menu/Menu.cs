using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interface;
using BleakwindBuffet.Data.Entrees;


namespace BleakwindBuffet.Data.Menu
{
    public class Menu
    {
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> tj = new List<IOrderItem>();
            tj.Add(new BriarheartBurger());
            tj.Add(new DoubleDraugr());
            tj.Add(new GardenOrcOmelette());
            tj.Add(new PhillyPoacher());
            tj.Add(new SmokehouseSkeleton());
            tj.Add(new ThalmorTriple());
            tj.Add(new ThugsTBone());
            return tj;
        }
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> tj = new List<IOrderItem>();

        }
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> tj = new List<IOrderItem>();
        }
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> tj = new List<IOrderItem>();
            tj.AddRange(Entrees());
            tj.AddRange(Drinks());
            tj.AddRange(Sides());
            return tj;
        }
    }
}

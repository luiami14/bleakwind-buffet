/*
 * Author: Luis Amiel
 * Class name: Menu.cs
 * Purpose: Just a simple menu class
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interface;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace BleakwindBuffet.Data.Menu
{
    public static class Menu
    {
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> items, string s)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            if (s == null) return FullMenu();

            foreach (IOrderItem item in FullMenu())
            {
                if (item.Calories != 0 && item.Price != 0)
                {
                    results.Add(item);
                }
            }
            return results;
        }
        public static string[] Category
        {
            get => new string[]
            {
                "Entrees",
                "Drinks", 
                "Sides"
            };
        }
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> s)
        {
            if (s == null || s.Count() == 0) return items;

            List<IOrderItem> results = new List<IOrderItem>();
            foreach(IOrderItem item in items)
            {
                if(s.Contains("Entrees") && item is  )
                {

                }
            }
            return results;
        }

        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, int? min, int? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();
            if (min == null)
            {
                foreach (IOrderItem movie in items)
                {
                    if (movie.Calories <= max) results.Add(movie);
                }
                return results;
            }
            if (max == null)
            {
                foreach (IOrderItem movie in items)
                {
                    if (movie.Calories >= min) results.Add(movie);
                }

                return results;
            }
            foreach (IOrderItem movie in items)
            {
                if (movie.Calories >= min && movie.Calories <= max)
                {
                    results.Add(movie);
                }
            }
            return results;
        }
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();
            if (min == null)
            {
                foreach (IOrderItem movie in items)
                {
                    if (movie.Price <= max) results.Add(movie);
                }
                return results;
            }
            if (max == null)
            {
                foreach (IOrderItem movie in items)
                {
                    if (movie.Price >= min) results.Add(movie);
                }

                return results;
            }
            foreach (IOrderItem movie in items)
            {
                if (movie.Price >= min && movie.Price <= max)
                {
                    results.Add(movie);
                }
            }
            return results;
        }
            /// <summary>
            /// The IOrder method for the Entrees
            /// </summary>
            /// <returns>returns the items on the list</returns>
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
        /// <summary>
        /// The IOrder method for the Sides
        /// </summary>
        /// <returns>returns the items on the list</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> tj = new List<IOrderItem>();

            DragonbornWaffleFries df = new DragonbornWaffleFries();
            df.Size = Size.Small;
            tj.Add(df);
            DragonbornWaffleFries dt = new DragonbornWaffleFries();
            dt.Size = Size.Medium;
            tj.Add(dt);
            DragonbornWaffleFries dr = new DragonbornWaffleFries();
            dr.Size = Size.Large;
            tj.Add(dr);

            FriedMiraak fm = new FriedMiraak();
            fm.Size = Size.Small;
            tj.Add(fm);
            FriedMiraak fr = new FriedMiraak();
            fr.Size = Size.Medium;
            tj.Add(fr);
            FriedMiraak ft = new FriedMiraak();
            ft.Size = Size.Large;
            tj.Add(ft);

            MadOtarGrits md = new MadOtarGrits();
            md.Size = Size.Small;
            tj.Add(md);
            MadOtarGrits mt = new MadOtarGrits();
            mt.Size = Size.Medium;
            tj.Add(mt);
            MadOtarGrits mf = new MadOtarGrits();
            mf.Size = Size.Large;
            tj.Add(mf);

            VokunSalad vs = new VokunSalad();
            vs.Size = Size.Small;
            tj.Add(vs);
            VokunSalad vt = new VokunSalad();
            vt.Size = Size.Medium;
            tj.Add(vt);
            VokunSalad vm = new VokunSalad();
            vm.Size = Size.Large;
            tj.Add(vm);
            return tj;
        }
        /// <summary>
        /// The IOrder method for the Drinks
        /// </summary>
        /// <returns>returns the items on the list</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> tj = new List<IOrderItem>();
            for(int num=0; num<3; num++)
            {
                tj.Add(new AretinoAppleJuice());
            }
            for (int num = 0; num < 3; num++)
            {
                tj.Add(new CandlehearthCoffee());
            }
            for (int num = 0; num < 3; num++)
            {
                tj.Add(new MarkarthMilk());
            }
            int flavor = 0;
            for(int i = 0;i<6;i++)
            {
                for(int k = 0;k<3;k++)
                {
                    SailorSoda sd = new SailorSoda();
                    sd.Size = (Size)k;
                    sd.Flavor = (SodaFlavor)flavor;
                    tj.Add(sd);
                }
                flavor++;
            }
            for (int num = 0; num < 3; num++)
            {
                tj.Add(new WarriorWater());
            }
            int size = 0;
            foreach(Drink drink in tj)
            {
                drink.Size = (Size)size;
                if(size<2)
                {
                    size++;
                }
                else
                {
                    size = 0;
                }
            }
            return tj;
        }
        /// <summary>
        /// The IOrder method for the FullMenu
        /// </summary>
        /// <returns>returns the items on the list</returns>
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

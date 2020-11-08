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
        public static IEnumerable<IOrderItem> Search(string s)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            if (s == null) return FullMenu();

            foreach (IOrderItem item in FullMenu())
            {
                if (item is Entree entree)
                {
                    if(entree is BriarheartBurger briar && briar.Name != null && briar.Name.Contains(s, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(briar);
                    }
                    else if(entree is DoubleDraugr doub && doub.Name != null && doub.Name.Contains(s, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(doub);
                    }
                    else if(entree is GardenOrcOmelette go && go.Name != null && go.Name.Contains(s, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(go);
                    }
                    else if (entree is PhillyPoacher pp && pp.Name != null && pp.Name.Contains(s, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(pp);
                    }
                    else if (entree is SmokehouseSkeleton ss && ss.Name != null && ss.Name.Contains(s, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(ss);
                    }
                    else if (entree is ThalmorTriple tt && tt.Name != null && tt.Name.Contains(s, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(tt);
                    }
                    else if (entree is ThugsTBone tb && tb.Name != null && tb.Name.Contains(s, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(tb);
                    }
                }
                else if(item is Drink drink)
                {
                    if (drink is AretinoAppleJuice aj && aj.Name != null && aj.Name.Contains(s, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(aj);
                    }
                    else if(drink is CandlehearthCoffee cc && cc.Name != null && cc.Name.Contains(s, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(cc);
                    }
                    else if (drink is MarkarthMilk mm && mm.Name != null && mm.Name.Contains(s, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(mm);
                    }
                    else if (drink is SailorSoda ss && ss.Name != null && ss.Name.Contains(s, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(ss);
                    }
                    else if (drink is WarriorWater ww && ww.Name != null && ww.Name.Contains(s, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(ww);
                    }
                }
                else if(item is Side side)
                {
                    if (side is DragonbornWaffleFries df && df.Name != null && df.Name.Contains(s, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(df);
                    }
                    else if (side is FriedMiraak fm && fm.Name != null && fm.Name.Contains(s, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(fm);
                    }
                    else if (side is MadOtarGrits mg && mg.Name != null && mg.Name.Contains(s, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(mg);
                    }
                    else if (side is VokunSalad vs && vs.Name != null && vs.Name.Contains(s, StringComparison.InvariantCultureIgnoreCase))
                    {
                        results.Add(vs);
                    }
                }
            }
            return results;
        }
        public static string[] Category
        {
            get => new string[]
            {
                "Entree",
                "Drink", 
                "Side"
            };
        }
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> s)
        {
            if (s == null || s.Count() == 0) return items;

            List<IOrderItem> results = new List<IOrderItem>();
            foreach(IOrderItem item in items)
            {
                if(s.Contains("Entree") && item is Entree entree )
                {
                    results.Add(entree);
                }
                if(s.Contains("Side") && item is Side side)
                {
                    results.Add(side);
                }
                if(s.Contains("Drink") && item is Drink drink)
                {
                    results.Add(drink);
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

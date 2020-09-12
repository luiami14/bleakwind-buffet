using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interface;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;


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
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> tj = new List<IOrderItem>();
            AretinoAppleJuice sj = new AretinoAppleJuice();
            CandlehearthCoffee cc = new CandlehearthCoffee();
            MarkarthMilk mm = new MarkarthMilk();
            SailorSoda ss = new SailorSoda();
            WarriorWater ww = new WarriorWater();

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


            for (int num = 0; num < 3; num++)
            {
                tj.Add(new SailorSoda());
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

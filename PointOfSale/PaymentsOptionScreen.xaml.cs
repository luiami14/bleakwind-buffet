using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Interface;
using RoundRegister;
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
    /// Interaction logic for PaymentsOptionScreen.xaml
    /// </summary>
    public partial class PaymentsOptionScreen : UserControl
    {
        /* private back end variable*/
        private Container cn;
        /// <summary>
        /// Property that contains the Container that I created
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
        /* private back end variable*/
        private BleakwindBuffet.Data.Combo cc;
        /// <summary>
        /// This is the contructor
        /// </summary>
        public PaymentsOptionScreen()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This button cancels the order and goes back
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
        /// This button returns to the order screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ReturnToOrder(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                cn.MenuSelectionComponent.Child = new ComboCutomizationScreen() { Container = cn };
            }
        }
        /// <summary>
        /// This is when the user clikc on the credit or debit card button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CreditDebitCard(object sender, RoutedEventArgs e)
        {
            RegisterModelView reg = new RegisterModelView();
            double num = ((Order)cn.DataContext).Total;
            CardTransactionResult transResult = reg.RunCard(num);
            if(transResult == CardTransactionResult.Approved)
            {
                reg.PrintLine("Order #" + ((Order)cn.DataContext).Total);
                DateTime time = DateTime.Now;
                reg.PrintLine(time.ToString());

                foreach(IOrderItem item in ((Order)cn.DataContext))
                {
                    if (item is BleakwindBuffet.Data.Drinks.AretinoAppleJuice aj)
                    {
                        reg.PrintLine(aj.Name + "\t" + aj.Price);
                        foreach (string str in aj.SpecialInstructions)
                        {
                            reg.PrintLine(str);
                        }
                    }
                    else if (item is BleakwindBuffet.Data.Drinks.CandlehearthCoffee cc)
                    {
                        reg.PrintLine(cc.Name + "\t" + cc.Price);
                        foreach (string str in cc.SpecialInstructions)
                        {
                            reg.PrintLine(str);
                        }
                    }
                    else if (item is BleakwindBuffet.Data.Drinks.MarkarthMilk mm)
                    {
                        reg.PrintLine(mm.Name + "\t" + mm.Price);
                        foreach (string str in mm.SpecialInstructions)
                        {
                            reg.PrintLine(str);
                        }
                    }
                    else if (item is BleakwindBuffet.Data.Drinks.SailorSoda ss)
                    {
                        reg.PrintLine(ss.Name + "\t" + ss.Price);
                        foreach (string str in ss.SpecialInstructions)
                        {
                            reg.PrintLine(str);
                        }
                    }
                    else if (item is BleakwindBuffet.Data.Drinks.WarriorWater ww)
                    {
                        reg.PrintLine(ww.Name + "\t" + ww.Price);
                        foreach (string str in ww.SpecialInstructions)
                        {
                            reg.PrintLine(str);
                        }
                    }
                    else if (item is BleakwindBuffet.Data.Entrees.BriarheartBurger bb)
                    {
                        reg.PrintLine(bb.Name + "\t" + bb.Price);
                        foreach (string str in bb.SpecialInstructions)
                        {
                            reg.PrintLine(str);
                        }
                    }
                    else if (item is BleakwindBuffet.Data.Entrees.DoubleDraugr dd)
                    {
                        reg.PrintLine(dd.Name + "\t" + dd.Price);
                        foreach (string str in dd.SpecialInstructions)
                        {
                            reg.PrintLine(str);
                        }
                    }
                    else if (item is BleakwindBuffet.Data.Entrees.GardenOrcOmelette go)
                    {
                        reg.PrintLine(go.Name + "\t" + go.Price);
                        foreach (string str in go.SpecialInstructions)
                        {
                            reg.PrintLine(str);
                        }
                    }
                    else if (item is BleakwindBuffet.Data.Entrees.PhillyPoacher pp)
                    {
                        reg.PrintLine(pp.Name + "\t" + pp.Price);
                        foreach (string str in pp.SpecialInstructions)
                        {
                            reg.PrintLine(str);
                        }
                    }
                    else if (item is BleakwindBuffet.Data.Entrees.SmokehouseSkeleton sl)
                    {
                        reg.PrintLine(sl.Name + "\t" + sl.Price);
                        foreach (string str in sl.SpecialInstructions)
                        {
                            reg.PrintLine(str);
                        }
                    }
                    else if (item is BleakwindBuffet.Data.Entrees.ThalmorTriple tl)
                    {
                        reg.PrintLine(tl.Name + "\t" + tl.Price);
                        foreach (string str in tl.SpecialInstructions)
                        {
                            reg.PrintLine(str);
                        }
                    }
                    else if (item is BleakwindBuffet.Data.Entrees.ThugsTBone tt)
                    {
                        reg.PrintLine(tt.Name + "\t" + tt.Price);
                        foreach (string str in tt.SpecialInstructions)
                        {
                            reg.PrintLine(str);
                        }
                    }
                    else if (item is BleakwindBuffet.Data.Sides.DragonbornWaffleFries df)
                    {
                        reg.PrintLine(df.Name + "\t" + df.Price);
                    }
                    else if (item is BleakwindBuffet.Data.Sides.FriedMiraak fm)
                    {
                        reg.PrintLine(fm.Name + "\t" + fm.Price);
                    }
                    else if (item is BleakwindBuffet.Data.Sides.MadOtarGrits mo)
                    {
                        reg.PrintLine(mo.Name + "\t" + mo.Price);
                    }
                    else if (item is BleakwindBuffet.Data.Sides.VokunSalad vs)
                    {
                        reg.PrintLine(vs.Name + "\t" + vs.Price);
                    }
                    else if(item is BleakwindBuffet.Data.Combo combo)
                    {
                        reg.PrintLine("combo" + "\t" + combo.Price);
                        foreach(string str in combo.SpecialInstructions)
                        {
                            reg.PrintLine(str);
                        }
                    }
                }
                reg.PrintLine("Subtotal:\t" + ((Order)cn.DataContext).Subtotal);
                reg.PrintLine("Tax:\t" + ((Order)cn.DataContext).Tax);
                reg.PrintLine("Total:\t" + ((Order)cn.DataContext).Total);
                reg.PrintLine("Changed Owed:\t$0.00");
                reg.PrintLine("Payment Method:\tCard");
                reg.CutTape();

                Container.DataContext = new Order();
                cn.MenuSelectionComponent.Child = new View1() { Container = cn };
            }
        }
    }
}

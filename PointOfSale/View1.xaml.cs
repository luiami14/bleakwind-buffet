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
        Container cn;

        public View1(Container c)
        {
            InitializeComponent();
            cn = c;
        }

        void ClicksButton(object sender, RoutedEventArgs e)
        {
            Button bt = (Button) sender;
            if (bt.Name == "BriarheartBurger") cn.MenuSelectionComponent.Child = new BriarheartBurger(cn);
            else if (bt.Name == "AretinoAppleJuice") cn.MenuSelectionComponent.Child = new AretinoAppleJuice(cn);
            else if (bt.Name == "CandlehearthCoffee") cn.MenuSelectionComponent.Child = new CandlehearthCoffee(cn);
            else if (bt.Name == "DoubleDraugr") cn.MenuSelectionComponent.Child = new DoubleDraugr(cn);
            else if (bt.Name == "DragonbornWaffleFries") cn.MenuSelectionComponent.Child = new DragonbornWaffleFries(cn);
            else if (bt.Name == "FriedMiraak") cn.MenuSelectionComponent.Child = new FriedMiraak(cn);
            else if (bt.Name == "GardenOrcOmelette") cn.MenuSelectionComponent.Child = new GardenOrcOmelette(cn);
            else if (bt.Name == "MadOtarGrits") cn.MenuSelectionComponent.Child = new MadOtarGrits(cn);
            else if (bt.Name == "MarkathMilk") cn.MenuSelectionComponent.Child = new MarkathMilk(cn);
            else if (bt.Name == "PhillyPoacher") cn.MenuSelectionComponent.Child = new PhillyPoacher(cn);
            else if (bt.Name == "SailorSoda") cn.MenuSelectionComponent.Child = new SailorSoda(cn);
            else if (bt.Name == "SmokehouseSkeleton") cn.MenuSelectionComponent.Child = new SmokehouseSkeleton(cn);
            else if (bt.Name == "ThalmorTriple") cn.MenuSelectionComponent.Child = new ThalmorTriple(cn);
            else if (bt.Name == "ThugsTBone") cn.MenuSelectionComponent.Child = new ThugsTBone(cn);
            else if (bt.Name == "VokunSalad") cn.MenuSelectionComponent.Child = new VokunSalad(cn);
            else if (bt.Name == "WarriorWater") cn.MenuSelectionComponent.Child = new WarriorWater(cn);
        }

    }
}

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interface;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests
{
    public class ComboTests
    {
        [Fact]
        public void ImplementsINotifyPropertyChange()
        {
            Combo c = new Combo();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(c);
        }
        [Fact]
        public void ImplementsIOrderItem()
        {
            Combo c = new Combo();
            Assert.IsAssignableFrom<IOrderItem>(c);
        }
        [Fact]
        public void ChangingDrinkNotifiesPriceProperty()
        {
            Combo d = new Combo();
            Assert.PropertyChanged(d, "Price", () => d.Drink = new AretinoAppleJuice());
        }
        [Fact]
        public void ChangingDrinkNotifiesCaloriesProperty()
        {
            Combo d = new Combo();
            Assert.PropertyChanged(d, "Calories", () => d.Drink = new AretinoAppleJuice());
        }
        [Fact]
        public void ChangingDrinkNotifiesSpecialInstructionsProperty()
        {
            Combo d = new Combo();
            Assert.PropertyChanged(d, "SpecialInstructions", () => d.Drink = new AretinoAppleJuice());
        }
        [Fact]
        public void ChangingSideNotifiesPriceProperty()
        {
            Combo d = new Combo();
            Assert.PropertyChanged(d, "Price", () => d.Side = new VokunSalad());
        }
        [Fact]
        public void ChangingSideNotifiesCaloriesProperty()
        {
            Combo d = new Combo();
            Assert.PropertyChanged(d, "Calories", () => d.Side = new VokunSalad());
        }
        [Fact]
        public void ChangingSideNotifiesSpecialInstructionsProperty()
        {
            Combo d = new Combo();
            Assert.PropertyChanged(d, "SpecialInstructions", () => d.Side = new VokunSalad());
        }
        [Fact]
        public void ChangingEntreeNotifiesPriceProperty()
        {
            Combo d = new Combo();
            Assert.PropertyChanged(d, "Price", () => d.Entree = new BriarheartBurger());
        }
        [Fact]
        public void ChangingEntreeNotifiesCaloriesProperty()
        {
            Combo d = new Combo();
            Assert.PropertyChanged(d, "Calories", () => d.Entree = new BriarheartBurger());
        }
        [Fact]
        public void ChangingEntreeNotifiesSpecialInstructionsProperty()
        {
            Combo d = new Combo();
            Assert.PropertyChanged(d, "SpecialInstructions", () => d.Entree = new BriarheartBurger());
        }
        [Fact]
        public void ShouldBePriceDefault()
        {
            Combo d = new Combo();
            Assert.Equal(7.16, d.Price);
        }
        [Fact]
        public void ShouldBeCaloriesDefault()
        {
            Combo d = new Combo();
            Assert.Equal((uint) 936, d.Calories);
        }
        [Fact]
        public void ShouldBeSpecialInstructionsDefault()
        {
            Combo d = new Combo();
            List<string> total = d.SpecialInstructions;
            Assert.Equal(total, d.SpecialInstructions);
        }
        [Fact]
        public void ChangingDrinkSizeNotifiesPriceProperty()
        {
            Combo d = new Combo();
            Assert.PropertyChanged(d, "Price", () => d.Drink.Size = Data.Enums.Size.Medium);
        }
        [Fact]
        public void ChangingDrinkSizeNotifiesCaloriesProperty()
        {
            Combo d = new Combo();
            Assert.PropertyChanged(d, "Calories", () => d.Drink.Size = Data.Enums.Size.Medium);
        }
        [Fact]
        public void ChangingDrinkSizeNotifiesSpecialInstructionsProperty()
        {
            Combo d = new Combo();
            Assert.PropertyChanged(d, "SpecialInstructions", () => d.Drink.Size = Data.Enums.Size.Medium);
        }
        [Fact]
        public void ChangingDrinkFlavorNotifiesPriceProperty()
        {
            Combo d = new Combo();
            SailorSoda ss = new SailorSoda();
            d.Drink= ss;
            Assert.PropertyChanged(d, "Price", () => ((SailorSoda)d.Drink).Flavor = Data.Enums.SodaFlavor.Blackberry);
        }
        [Fact]
        public void ChangingDrinkFlavorNotifiesCaloriesProperty()
        {
            Combo d = new Combo();
            SailorSoda ss = new SailorSoda();
            d.Drink = ss;
            Assert.PropertyChanged(d, "Calories", () => ((SailorSoda)d.Drink).Flavor = Data.Enums.SodaFlavor.Lemon);
        }
        [Fact]
        public void ChangingDrinkFlavorNotifiesSpecialInstructionsProperty()
        {
            Combo d = new Combo();
            SailorSoda ss = new SailorSoda();
            d.Drink = ss;
            Assert.PropertyChanged(d, "SpecialInstructions", () => ((SailorSoda)d.Drink).Flavor = Data.Enums.SodaFlavor.Peach);
        }
        [Fact]
        public void ChangingDrinkSpecialInstructionsNotifiesPriceProperty()
        {
            Combo d = new Combo();
            SailorSoda ss = new SailorSoda();
            d.Drink = ss;
            Assert.PropertyChanged(d, "Price", () => ((SailorSoda)d.Drink).Ice = true);
        }
        [Fact]
        public void ChangingDrinkSpecialInstructionsNotifiesCaloriesProperty()
        {
            Combo d = new Combo();
            SailorSoda ss = new SailorSoda();
            d.Drink = ss;
            Assert.PropertyChanged(d, "Calories", () => ((SailorSoda)d.Drink).Ice = true);
        }
        [Fact]
        public void ChangingDrinkSpecialInstructionsNotifiesSpecialInstructionsProperty()
        {
            Combo d = new Combo();
            SailorSoda ss = new SailorSoda();
            d.Drink = ss;
            Assert.PropertyChanged(d, "SpecialInstructions", () => ((SailorSoda)d.Drink).Ice = true);
        }
        [Fact]
        public void ChangingEntreeNotifiesProperty()
        {
            Combo d = new Combo();
            BriarheartBurger ss = new BriarheartBurger();
            d.Entree = ss;
            Assert.PropertyChanged(d, "SpecialInstructions", () => ((BriarheartBurger)d.Entree).Bun = true);
        }
        [Fact]
        public void ChangingSideNotifiesProperty()
        {
            Combo d = new Combo();
            VokunSalad vk = new VokunSalad();
            d.Side = vk;
            Assert.PropertyChanged(d, "SpecialInstructions", () => ((VokunSalad)d.Side).Size = Data.Enums.Size.Medium);
        }
    }
}

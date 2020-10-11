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
            Assert.Equals(("Hold Ice", d.SpecialInstructions);
        }
    }
}

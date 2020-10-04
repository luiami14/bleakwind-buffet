/*
 * Author: Luis Amiel
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interface;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        /// <summary>
        /// A test that tests if it should be a entree
        /// </summary>
        [Fact]
        public void ShouldBeAEntree()
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(tj);
        }
        /// <summary>
        /// A test that tests if it should be a orderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(tj);
        }
        /// <summary>
        /// includes bun by default
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.True(tj.Bun);
        }
        /// <summary>
        /// includes ket by default
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.True(tj.Ketchup);
        }
        /// <summary>
        /// includes mustard by default
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.True(tj.Mustard);
        }
        /// <summary>
        /// includes pickle by default
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.True(tj.Pickle);
        }
        /// <summary>
        /// includes cheese by default
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.True(tj.Cheese);
        }
        /// <summary>
        /// includes tomato by default
        /// </summary>
        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.True(tj.Tomato);
        }
        /// <summary>
        /// includes lettuce by default
        /// </summary>
        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.True(tj.Lettuce);
        }
        /// <summary>
        /// includes mayo by default
        /// </summary>
        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.True(tj.Mayo);
        }
        /// <summary>
        /// includes bacon by default
        /// </summary>
        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.True(tj.Bacon);
        }
        /// <summary>
        /// includes eggs by default
        /// </summary>
        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.True(tj.Egg);
        }
        /// <summary>
        /// sets to bun
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple tj = new ThalmorTriple();
            tj.Bun = true;
            Assert.True(tj.Bun);
            tj.Bun = false;
            Assert.False(tj.Bun);
        }
        /// <summary>
        /// sets to ketchup
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple tj = new ThalmorTriple();
            tj.Ketchup = true;
            Assert.True(tj.Ketchup);
            tj.Ketchup = false;
            Assert.False(tj.Ketchup);
        }
        /// <summary>
        /// sets to mustard
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple tj = new ThalmorTriple();
            tj.Mustard = true;
            Assert.True(tj.Mustard);
            tj.Mustard = false;
            Assert.False(tj.Mustard);
        }
        /// <summary>
        /// sets to pickle
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple tj = new ThalmorTriple();
            tj.Pickle = true;
            Assert.True(tj.Pickle);
            tj.Pickle = false;
            Assert.False(tj.Pickle);
        }
        /// <summary>
        /// sets to cheese
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple tj = new ThalmorTriple();
            tj.Cheese = true;
            Assert.True(tj.Cheese);
            tj.Cheese = false;
            Assert.False(tj.Cheese);
        }
        /// <summary>
        /// sets to tomato
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple tj = new ThalmorTriple();
            tj.Tomato = true;
            Assert.True(tj.Tomato);
            tj.Tomato = false;
            Assert.False(tj.Tomato);
        }
        /// <summary>
        /// sets to lettuce
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple tj = new ThalmorTriple();
            tj.Lettuce = true;
            Assert.True(tj.Lettuce);
            tj.Lettuce = false;
            Assert.False(tj.Lettuce);
        }
        /// <summary>
        /// sets to mayo
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple tj = new ThalmorTriple();
            tj.Mayo = true;
            Assert.True(tj.Mayo);
            tj.Mayo = false;
            Assert.False(tj.Mayo);
        }
        /// <summary>
        /// sets to bacon
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple tj = new ThalmorTriple();
            tj.Bacon = true;
            Assert.True(tj.Bacon);
            tj.Bacon = false;
            Assert.False(tj.Bacon);
        }
        /// <summary>
        /// sets to egg
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple tj = new ThalmorTriple();
            tj.Egg = true;
            Assert.True(tj.Egg);
            tj.Egg = false;
            Assert.False(tj.Egg);
        }
        /// <summary>
        /// returns correct price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.Equal(8.32, tj.Price);
        }
        /// <summary>
        /// returns correct calories
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.Equal((uint)943, tj.Calories);
        }
        /// <summary>
        /// returns special instructions 
        /// </summary>
        /// <param name="includeBun">bun parameter</param>
        /// <param name="includeKetchup">ket parameter</param>
        /// <param name="includeMustard">mustard parameter</param>
        /// <param name="includePickle">pickle parameter</param>
        /// <param name="includeCheese">cheese parameter</param>
        /// <param name="includeTomato">tomato parameter</param>
        /// <param name="includeLettuce">lettuce parameter</param>
        /// <param name="includeMayo">mayo parameter</param>
        /// <param name="includeBacon">bacon parameter</param>
        /// <param name="includeEgg">egg parameter</param>
        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple tj = new ThalmorTriple();
            tj.Bun = includeBun;
            tj.Ketchup = includeKetchup;
            tj.Mustard = includeMustard;
            tj.Pickle = includePickle;
            tj.Cheese = includeCheese;
            tj.Tomato = includeTomato;
            tj.Lettuce = includeLettuce;
            tj.Mayo = includeMayo;
            tj.Bacon = includeBacon;
            tj.Egg = includeEgg;
            if (!includeBun) Assert.Contains("Hold bun", tj.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", tj.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", tj.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", tj.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", tj.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", tj.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", tj.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", tj.SpecialInstructions);
            if (!includeBacon) Assert.Contains("Hold bacon", tj.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold egg", tj.SpecialInstructions);
            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese && includeTomato && includeLettuce && includeMayo && includeBacon && includeEgg) Assert.Empty(tj.SpecialInstructions);
        }
        /// <summary>
        /// returns correct toString()
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", tj.ToString());
        }
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingBunNotifiesBunProperty(bool bun)
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.PropertyChanged(tj, "Bun", () => tj.Bun = bun);
        }
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingKetchupNotifiesKetchupProperty(bool ketchup)
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.PropertyChanged(tj, "Ketchup", () => tj.Ketchup = ketchup);
        }
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingMustardNotifiesMustardProperty(bool mustard)
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.PropertyChanged(tj, "Mustard", () => tj.Mustard = mustard);
        }
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingPickleNotifiesPickleProperty(bool pickle)
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.PropertyChanged(tj, "Pickle", () => tj.Pickle = pickle);
        }
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingCheeseNotifiesCheeseProperty(bool cheese)
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.PropertyChanged(tj, "Cheese", () => tj.Cheese = cheese);
        }
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingLettuceNotifiesLettuceProperty(bool lettuce)
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.PropertyChanged(tj, "Lettuce", () => tj.Lettuce = lettuce);
        }
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingMayoNotifiesMayoProperty(bool mayo)
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.PropertyChanged(tj, "Mayo", () => tj.Mayo = mayo);
        }
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingBaconNotifiesBaconProperty(bool bacon)
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.PropertyChanged(tj, "Bacon", () => tj.Bacon = bacon);
        }
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingEggNotifiesEggProperty(bool egg)
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.PropertyChanged(tj, "Egg", () => tj.Egg = egg);
        }
        [Fact]
        public void ImplementsINotifyPropertyChange()
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(tj);
        }
    }
}
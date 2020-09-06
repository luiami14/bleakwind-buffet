/*
 * Author: Luis Amiel
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {
        /// <summary>
        /// includes bun by default
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr dj = new DoubleDraugr();
            Assert.True(dj.Bun);
        }
        /// <summary>
        /// includes ket by default
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr dj = new DoubleDraugr();
            Assert.True(dj.Ketchup);
        }
        /// <summary>
        /// includes mustard by default
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr dj = new DoubleDraugr();
            Assert.True(dj.Mustard);
        }
        /// <summary>
        /// includes pickle by default
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr dj = new DoubleDraugr();
            Assert.True(dj.Pickle);
        }
        /// <summary>
        /// includes cheese by default
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr dj = new DoubleDraugr();
            Assert.True(dj.Cheese);
        }
        /// <summary>
        /// includes tomato by default
        /// </summary>
        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr dj = new DoubleDraugr();
            Assert.True(dj.Tomato);
        }
        /// <summary>
        /// includes lettuce by default
        /// </summary>
        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr dj = new DoubleDraugr();
            Assert.True(dj.Lettuce);
        }
        /// <summary>
        /// includes mayo by default
        /// </summary>
        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr dj = new DoubleDraugr();
            Assert.True(dj.Mayo);
        }
        /// <summary>
        /// sets the bun
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr dj = new DoubleDraugr();
            dj.Bun = true;
            Assert.True(dj.Bun);
            dj.Bun = false;
            Assert.False(dj.Bun);
        }
        /// <summary>
        /// sets the ket
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr dj = new DoubleDraugr();
            dj.Ketchup = true;
            Assert.True(dj.Ketchup);
            dj.Ketchup = false;
            Assert.False(dj.Ketchup);
        }
        /// <summary>
        /// sets the mustard
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr dj = new DoubleDraugr();
            dj.Mustard = true;
            Assert.True(dj.Mustard);
            dj.Mustard = false;
            Assert.False(dj.Mustard);
        }
        /// <summary>
        /// sets the pickle
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr dj = new DoubleDraugr();
            dj.Pickle = true;
            Assert.True(dj.Pickle);
            dj.Pickle = false;
            Assert.False(dj.Pickle);
        }
        /// <summary>
        /// sets the cheese
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr dj = new DoubleDraugr();
            dj.Cheese = true;
            Assert.True(dj.Cheese);
            dj.Cheese = false;
            Assert.False(dj.Cheese);
        }
        /// <summary>
        /// sets the tomato
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr dj = new DoubleDraugr();
            dj.Tomato = true;
            Assert.True(dj.Tomato);
            dj.Tomato = false;
            Assert.False(dj.Tomato);
        }
        /// <summary>
        /// sets the lettuce
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr dj = new DoubleDraugr();
            dj.Lettuce = true;
            Assert.True(dj.Lettuce);
            dj.Lettuce = false;
            Assert.False(dj.Lettuce);
        }
        /// <summary>
        /// sets the mayo
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr dj = new DoubleDraugr();
            dj.Mayo = true;
            Assert.True(dj.Mayo);
            dj.Mayo = false;
            Assert.False(dj.Mayo);
        }
        /// <summary>
        /// returns the correct price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr dj = new DoubleDraugr();
            Assert.Equal(7.32, dj.Price);
        }
        /// <summary>
        /// returns the correct calories
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr dj = new DoubleDraugr();
            Assert.Equal((uint)843, dj.Calories);
        }
        /// <summary>
        /// returns special instructions
        /// </summary>
        /// <param name="includeBun">bun parameter</param>
        /// <param name="includeKetchup">ket paramter</param>
        /// <param name="includeMustard">mustard parameter</param>
        /// <param name="includePickle">pickle paramter</param>
        /// <param name="includeCheese">cheese parameter</param>
        /// <param name="includeTomato">tomato parameter</param>
        /// <param name="includeLettuce">lettuce parameter</param>
        /// <param name="includeMayo">mayo parameter</param>
        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr dj = new DoubleDraugr();
            dj.Bun = includeBun;
            dj.Ketchup = includeKetchup;
            dj.Mustard = includeMustard;
            dj.Pickle = includePickle;
            dj.Cheese = includeCheese;
            if (!includeBun) Assert.Contains("Hold bun", dj.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", dj.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", dj.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", dj.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", dj.SpecialInstructions);
            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese) Assert.Empty(dj.SpecialInstructions);
        }
        /// <summary>
        /// returns the correct string
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr dj = new DoubleDraugr();
            Assert.Equal("Double Draugr", dj.ToString());
        }
    }
}
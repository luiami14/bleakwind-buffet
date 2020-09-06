/*
 * Author: Luis Amiel
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        /// <summary>
        /// includes bun by default
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger bj = new BriarheartBurger();
            Assert.True(bj.Bun);
        }
        /// <summary>
        /// includes ketchup by default
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger bj = new BriarheartBurger();
            Assert.True(bj.Ketchup);
        }
        /// <summary>
        /// includes mustard by default
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger bj = new BriarheartBurger();
            Assert.True(bj.Mustard);
        }
        /// <summary>
        /// includes pickle by default
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger bj = new BriarheartBurger();
            Assert.True(bj.Pickle);
        }
        /// <summary>
        /// includes cheese by default
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger bj = new BriarheartBurger();
            Assert.True(bj.Cheese);
        }
        /// <summary>
        /// sets the bun
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger bj = new BriarheartBurger();
            bj.Bun = true;
            Assert.True(bj.Bun);
            bj.Bun = false;
            Assert.False(bj.Bun);
        }
        /// <summary>
        /// sets the ketchup
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger bj = new BriarheartBurger();
            bj.Ketchup = true;
            Assert.True(bj.Ketchup);
            bj.Ketchup = false;
            Assert.False(bj.Ketchup);
        }
        /// <summary>
        /// sets the mustard
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger bj = new BriarheartBurger();
            bj.Mustard = true;
            Assert.True(bj.Mustard);
            bj.Mustard = false;
            Assert.False(bj.Mustard);
        }
        /// <summary>
        /// sets the pickles
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger bj = new BriarheartBurger();
            bj.Pickle = true;
            Assert.True(bj.Pickle);
            bj.Pickle = false;
            Assert.False(bj.Pickle);
        }
        /// <summary>
        /// sets the cheese
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger bj = new BriarheartBurger();
            bj.Cheese = true;
            Assert.True(bj.Cheese);
            bj.Cheese = false;
            Assert.False(bj.Cheese);
        }
        /// <summary>
        /// returns the correct price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger bj = new BriarheartBurger();
            Assert.Equal(6.32, bj.Price);
        }
        /// <summary>
        /// returns the correct calories
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger bj = new BriarheartBurger();
            Assert.Equal((uint)732, bj.Calories);
            
        }
        /// <summary>
        /// returns special instructions
        /// </summary>
        /// <param name="includeBun">bun parameter</param>
        /// <param name="includeKetchup">ketchup parameter</param>
        /// <param name="includeMustard">mustard parameter</param>
        /// <param name="includePickle">pickle parameter</param>
        /// <param name="includeCheese">cheese parameter</param>
        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger bj = new BriarheartBurger();
            bj.Bun = includeBun;
            bj.Ketchup = includeKetchup;
            bj.Mustard = includeMustard;
            bj.Pickle = includePickle;
            bj.Cheese = includeCheese;
            if(!includeBun) Assert.Contains("Hold bun", bj.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", bj.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", bj.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", bj.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", bj.SpecialInstructions);
            if(includeBun&&includeKetchup&&includeMustard&&includePickle&&includeCheese) Assert.Empty(bj.SpecialInstructions);
        }
        /// <summary>
        /// returns the correct string
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger bj = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", bj.ToString());
        }
    }
}
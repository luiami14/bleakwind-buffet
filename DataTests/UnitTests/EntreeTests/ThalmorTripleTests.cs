/*
 * Author: Luis Amiel
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.True(tj.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.True(tj.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.True(tj.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.True(tj.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.True(tj.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.True(tj.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.True(tj.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.True(tj.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.True(tj.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple tj = new ThalmorTriple();
            Assert.True(tj.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple tj = new ThalmorTriple();
            tj.Bun = true;
            Assert.True(tj.Bun);
            tj.Bun = false;
            Assert.False(tj.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple tj = new ThalmorTriple();
            tj.Ketchup = true;
            Assert.True(tj.Ketchup);
            tj.Ketchup = false;
            Assert.False(tj.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple tj = new ThalmorTriple();
            tj.Mustard = true;
            Assert.True(tj.Mustard);
            tj.Mustard = false;
            Assert.False(tj.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple tj = new ThalmorTriple();
            tj.Pickle = true;
            Assert.True(tj.Pickle);
            tj.Pickle = false;
            Assert.False(tj.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple tj = new ThalmorTriple();
            tj.Cheese = true;
            Assert.True(tj.Cheese);
            tj.Cheese = false;
            Assert.False(tj.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple tj = new ThalmorTriple();
            tj.Tomato = true;
            Assert.True(tj.Tomato);
            tj.Tomato = false;
            Assert.False(tj.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple tj = new ThalmorTriple();
            tj.Lettuce = true;
            Assert.True(tj.Lettuce);
            tj.Lettuce = false;
            Assert.False(tj.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple tj = new ThalmorTriple();
            tj.Mayo = true;
            Assert.True(tj.Mayo);
            tj.Mayo = false;
            Assert.False(tj.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple tj = new ThalmorTriple();
            tj.Bacon = true;
            Assert.True(tj.Bacon);
            tj.Bacon = false;
            Assert.False(tj.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple tj = new ThalmorTriple();
            tj.Egg = true;
            Assert.True(tj.Egg);
            tj.Egg = false;
            Assert.False(tj.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
        }
    }
}
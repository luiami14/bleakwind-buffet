/*
 * Author: Luis Amiel
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Interface;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        /// <summary>
        /// A test that tests if it should be a drink
        /// </summary>
        [Fact]
        public void ShouldBeADrink()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(cc);
        }
        /// <summary>
        /// A test that tests if it should be a orderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<IOrderItem>(cc);
        }
        /// <summary>
        /// not include ice by default
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee cj = new CandlehearthCoffee();
            Assert.False(cj.Ice);
        }
        /// <summary>
        /// not include default by default
        /// </summary>
        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee cj = new CandlehearthCoffee();
            Assert.False(cj.Decaf);
        }
        /// <summary>
        /// not have room for cream by default
        /// </summary>
        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee cj = new CandlehearthCoffee();
            Assert.False(cj.RoomForCream);
        }
        /// <summary>
        /// small by default
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee cj = new CandlehearthCoffee();
            Assert.Equal(Size.Small, cj.Size);
        }
        /// <summary>
        /// set to ice
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee cj = new CandlehearthCoffee();
            cj.Ice = true;
            Assert.True(cj.Ice);
            cj.Ice = false;
            Assert.False(cj.Ice);
        }
        /// <summary>
        /// set to decaf
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee cj = new CandlehearthCoffee();
            cj.Decaf = true;
            Assert.True(cj.Decaf);
            cj.Decaf = false;
            Assert.False(cj.Decaf);
        }
        /// <summary>
        /// set room for cream
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee cj = new CandlehearthCoffee();
            cj.RoomForCream = true;
            Assert.True(cj.RoomForCream);
            cj.RoomForCream = false;
            Assert.False(cj.RoomForCream);
        }
        /// <summary>
        /// able to set for size
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee cj = new CandlehearthCoffee();
            cj.Size = Size.Large;
            Assert.Equal(Size.Large, cj.Size);
            cj.Size = Size.Medium;
            Assert.Equal(Size.Medium, cj.Size);
            cj.Size = Size.Small;
            Assert.Equal(Size.Small, cj.Size);
        }
        /// <summary>
        /// correct prize for size
        /// </summary>
        /// <param name="size">size parameter</param>
        /// <param name="price">name parameter</param>
        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee cj = new CandlehearthCoffee();
            cj.Size = size;
            Assert.Equal(price, cj.Price);
        }
        /// <summary>
        /// correct calories for the size
        /// </summary>
        /// <param name="size">size parameter</param>
        /// <param name="cal">calorie parameter</param>
        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee cj = new CandlehearthCoffee();
            cj.Size = size;
            Assert.Equal(cal, cj.Calories);
        }
        /// <summary>
        /// correct special instructions 
        /// </summary>
        /// <param name="includeIce">ice parameter</param>
        /// <param name="includeCream">cream parameter</param>
        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee cj = new CandlehearthCoffee();
            cj.Ice = includeIce;
            cj.RoomForCream = includeCream;
            if (includeIce) Assert.Contains("Add ice", cj.SpecialInstructions);
            if (includeCream) Assert.Contains("Add cream", cj.SpecialInstructions);
            if(!includeIce && !includeCream) Assert.Empty(cj.SpecialInstructions);
        }
        /// <summary>
        /// correct toString based on the size
        /// </summary>
        /// <param name="decaf">decaf parameter</param>
        /// <param name="size">size parameter</param>
        /// <param name="name">name parameter</param>
        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee cj = new CandlehearthCoffee();
            cj.Size = size;
            cj.Decaf = decaf;
            Assert.Equal(name, cj.ToString());
        }
    }
}

/*
 * Author: Luis Amiel
 * Class: WarriorWaterTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Interface;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        /// <summary>
        /// A test that tests if it should be a drink
        /// </summary>
        [Fact]
        public void ShouldBeADrink()
        {
            WarriorWater wj = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(wj);
        }
        /// <summary>
        /// A test that tests if it should be a orderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            WarriorWater wj = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(wj);
        }
        /// <summary>
        /// not include ice by default
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            WarriorWater wj = new WarriorWater();
            Assert.True(wj.Ice);
        }
        /// <summary>
        /// not include lemon by default
        /// </summary>
        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater wj = new WarriorWater();
            Assert.False(wj.Lemon);
        }
        /// <summary>
        /// small by default
        /// </summary>
        [Fact]
        public void ShouldBySmallByDefault()
        {
            WarriorWater wj = new WarriorWater();
            Assert.Equal(Size.Small, wj.Size);
        }
        /// <summary>
        /// set to a size
        /// </summary>
        [Fact]
        public void ShouldByAbleToSetIce()
        {
            WarriorWater wj = new WarriorWater();
            wj.Ice = true;
            Assert.True(wj.Ice);
            wj.Ice = false;
            Assert.False(wj.Ice);
        }
        /// <summary>
        /// set to lemon
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            WarriorWater wj = new WarriorWater();
            wj.Lemon = true;
            Assert.True(wj.Lemon);
            wj.Lemon = false;
            Assert.False(wj.Lemon);
        }
        /// <summary>
        /// able to set to a size
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater wj = new WarriorWater();
            wj.Size = Size.Large;
            Assert.Equal(Size.Large, wj.Size);
            wj.Size = Size.Medium;
            Assert.Equal(Size.Medium, wj.Size);
            wj.Size = Size.Small;
            Assert.Equal(Size.Small, wj.Size);
        }
        /// <summary>
        /// correct price for size
        /// </summary>
        /// <param name="size">size parameter</param>
        /// <param name="price">price parameter</param>
        [Theory]
        [InlineData(Size.Small, 0.00)]
        [InlineData(Size.Medium, 0.00)]
        [InlineData(Size.Large, 0.00)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            WarriorWater wj = new WarriorWater();
            wj.Size = size;
            Assert.Equal(price, wj.Price);
        }
        /// <summary>
        /// correct calories for the size
        /// </summary>
        /// <param name="size">size parameter</param>
        /// <param name="cal">calories parameter</param>
        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater wj = new WarriorWater();
            wj.Size = size;
            Assert.Equal(cal, wj.Calories);
        }
        /// <summary>
        /// correct special instructions
        /// </summary>
        /// <param name="includeIce">ice parameter</param>
        /// <param name="includeLemon">lemon parameter</param>
        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater wj = new WarriorWater();
            wj.Ice = includeIce;
            wj.Lemon = includeLemon;
            if (!includeIce) Assert.Contains("Hold ice", wj.SpecialInstructions);
            if (includeLemon) Assert.Contains("Add lemon", wj.SpecialInstructions);
            if(includeIce && !includeLemon) Assert.Empty(wj.SpecialInstructions);
        }
        /// <summary>
        /// correct ToString based on the size
        /// </summary>
        /// <param name="size">size parameter</param>
        /// <param name="name">name parameter</param>
        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater wj = new WarriorWater();
            wj.Size = size;
            Assert.Equal(name, wj.ToString());
        }
    }
}

/*
 * Author: Zachery Brunner
 * Class: WarriorWaterTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            WarriorWater wj = new WarriorWater();
            Assert.False(wj.Ice);
        }
        [Fact]
        public void ShouldBySmallByDefault()
        {
            WarriorWater wj = new WarriorWater();
            Assert.Equal(Size.Small, wj.Size);
        }
        [Fact]
        public void ShouldByAbleToSetIce()
        {
            WarriorWater wj = new WarriorWater();
            wj.Ice = true;
            Assert.True(wj.Ice);
            wj.Ice = false;
            Assert.False(wj.Ice);
        }
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
        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            WarriorWater wj = new WarriorWater();
            wj.Lemon = true;
            Assert.True(wj.Lemon);
            wj.Lemon = false;
            Assert.False(wj.Lemon);
        }
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            WarriorWater wj = new WarriorWater();
            wj.Ice = includeIce;
            if (!includeIce) Assert.Contains("Hold ice", wj.SpecialInstructions);
            else Assert.Empty(wj.SpecialInstructions);
        }
        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk mj = new MarkarthMilk();
            mj.Size = size;
        }
    }
}

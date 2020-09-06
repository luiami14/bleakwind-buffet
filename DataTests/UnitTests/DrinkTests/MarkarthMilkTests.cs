/*
 * Author: Zachery Brunner
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            MarkarthMilk mj = new MarkarthMilk();
            Assert.False(mj.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            MarkarthMilk mj = new MarkarthMilk();
            Assert.Equal(Size.Small, mj.Size);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            MarkarthMilk mj = new MarkarthMilk();
            mj.Ice = true;
            Assert.True(mj.Ice);
            mj.Ice = false;
            Assert.False(mj.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MarkarthMilk mj = new MarkarthMilk();
            mj.Size = Size.Large;
            Assert.Equal(Size.Large, mj.Size);
            mj.Size = Size.Medium;
            Assert.Equal(Size.Medium, mj.Size);
            mj.Size = Size.Small;
            Assert.Equal(Size.Small, mj.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk mj = new MarkarthMilk();
            mj.Size = size;
            Assert.Equal(price, mj.Price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk mj = new MarkarthMilk();
            mj.Size = size;
            Assert.Equal(cal, mj.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            MarkarthMilk mj = new MarkarthMilk();
            mj.Ice = includeIce;
            if (includeIce) Assert.Contains("Add ice", mj.SpecialInstructions);
            else Assert.Empty(mj.SpecialInstructions);

        }

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk mj = new MarkarthMilk();
            mj.Size = size;
        }
    }
}
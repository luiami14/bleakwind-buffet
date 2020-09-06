/*
 * Author: Luis Amiel
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class FriedMiraakTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            FriedMiraak fj = new FriedMiraak();
            Assert.Equal(Size.Small, fj.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            FriedMiraak fj = new FriedMiraak();
            fj.Size = Size.Large;
            Assert.Equal(Size.Large, fj.Size);
            fj.Size = Size.Medium;
            Assert.Equal(Size.Medium, fj.Size);
            fj.Size = Size.Small;
            Assert.Equal(Size.Small, fj.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            FriedMiraak fj = new FriedMiraak();
            Assert.Empty(fj.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            FriedMiraak fj = new FriedMiraak();
            fj.Size = size;
            Assert.Equal(price, fj.Price);
        }

        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            FriedMiraak fj = new FriedMiraak();
            fj.Size = size;
            Assert.Equal(calories, fj.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            FriedMiraak fj = new FriedMiraak();
            fj.Size = size;
            Assert.Equal(name, fj.ToString());
        }
    }
}
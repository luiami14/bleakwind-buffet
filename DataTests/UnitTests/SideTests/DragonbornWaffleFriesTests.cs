/*
 * Author: Luis Amiel
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries dj = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, dj.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries dj = new DragonbornWaffleFries();
            dj.Size = Size.Large;
            Assert.Equal(Size.Large, dj.Size);
            dj.Size = Size.Medium;
            Assert.Equal(Size.Medium, dj.Size);
            dj.Size = Size.Small;
            Assert.Equal(Size.Small, dj.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries dj = new DragonbornWaffleFries();
            Assert.Empty(dj.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries dj = new DragonbornWaffleFries();
            dj.Size = size;
            Assert.Equal(price, dj.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries dj = new DragonbornWaffleFries();
            dj.Size = size;
            Assert.Equal(calories, dj.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries dj = new DragonbornWaffleFries();
            dj.Size = size;
            Assert.Equal(name, dj.ToString());
        }
    }
}
/*
 * Author: Luis Amiel
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class VokunSaladTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            VokunSalad vj = new VokunSalad();
            Assert.Equal(Size.Small, vj.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            VokunSalad vj = new VokunSalad();
            vj.Size = Size.Large;
            Assert.Equal(Size.Large, vj.Size);
            vj.Size = Size.Medium;
            Assert.Equal(Size.Medium, vj.Size);
            vj.Size = Size.Small;
            Assert.Equal(Size.Small, vj.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            VokunSalad vj = new VokunSalad();
            Assert.Empty(vj.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            VokunSalad vj = new VokunSalad();
            vj.Size = size;
            Assert.Equal(price, vj.Price);
        }

        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            VokunSalad vj = new VokunSalad();
            vj.Size = size;
            Assert.Equal(calories, vj.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            VokunSalad vj = new VokunSalad();
            vj.Size = size;
            Assert.Equal(name, vj.ToString());
        }
    }
}
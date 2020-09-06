/*
 * Author: Luis Amiel
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits mj = new MadOtarGrits();
            Assert.Equal(Size.Small, mj.Size);
        }
                
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits mj = new MadOtarGrits();
            mj.Size = Size.Large;
            Assert.Equal(Size.Large, mj.Size);
            mj.Size = Size.Medium;
            Assert.Equal(Size.Medium, mj.Size);
            mj.Size = Size.Small;
            Assert.Equal(Size.Small, mj.Size);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits mj = new MadOtarGrits();
            Assert.Empty(mj.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits mj = new MadOtarGrits();
            mj.Size = size;
            Assert.Equal(price, mj.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits mj = new MadOtarGrits();
            mj.Size = size;
            Assert.Equal(calories, mj.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits mj = new MadOtarGrits();
            mj.Size = size;
            Assert.Equal(name, mj.ToString());
        }
    }
}
/*
 * Author: Luis Amiel
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Interface;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        /// <summary>
        /// A test that tests if it should be a Side
        /// </summary>
        [Fact]
        public void ShouldBeASide()
        {
            MadOtarGrits mj = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(mj);
        }
        /// <summary>
        /// A test that tests if it should be a orderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            MadOtarGrits mj = new MadOtarGrits(); 
            Assert.IsAssignableFrom<IOrderItem>(mj);
        }
        /// <summary>
        /// small by default
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits mj = new MadOtarGrits();
            Assert.Equal(Size.Small, mj.Size);
        }
        /// <summary>
        /// able to set any size
        /// </summary>
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
        /// <summary>
        /// returns special instructions
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits mj = new MadOtarGrits();
            Assert.Empty(mj.SpecialInstructions);
        }
        /// <summary>
        /// correct price based on size
        /// </summary>
        /// <param name="size">size parameter</param>
        /// <param name="price">price parameter</param>
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
        /// <summary>
        /// correct calories based on  size
        /// </summary>
        /// <param name="size">size parameter</param>
        /// <param name="calories">calories parameter</param>
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
        /// <summary>
        /// returns correct string based on the size
        /// </summary>
        /// <param name="size">size parameter</param>
        /// <param name="name">name parameter</param>
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
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesSizeProperty(Size size)
        {
            MadOtarGrits mj = new MadOtarGrits();
            Assert.PropertyChanged(mj, "Size", () => mj.Size = size);
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesCaloriesProperty(Size size)
        {
            MadOtarGrits mj = new MadOtarGrits();
            Assert.PropertyChanged(mj, "Calories", () => mj.Size = size);
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesPriceProperty(Size size)
        {
            MadOtarGrits mj = new MadOtarGrits();
            Assert.PropertyChanged(mj, "Price", () => mj.Size = size);
        }
    }
}
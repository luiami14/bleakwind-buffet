/*
 * Author: Luis Amiel
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Interface;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        /// <summary>
        /// A test that tests if it should be a Side
        /// </summary>
        [Fact]
        public void ShouldBeASide()
        {
            DragonbornWaffleFries dj = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(dj);
        }
        /// <summary>
        /// A test that tests if it should be a orderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            DragonbornWaffleFries dj = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<IOrderItem>(dj);
        }
        /// <summary>
        /// small is set to default
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries dj = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, dj.Size);
        }
        /// <summary>
        /// this makes it to set a size
        /// </summary>
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
        /// <summary>
        /// there are no special instructions
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries dj = new DragonbornWaffleFries();
            Assert.Empty(dj.SpecialInstructions);
        }
        /// <summary>
        /// returns price based on the users price
        /// </summary>
        /// <param name="size">size parameter</param>
        /// <param name="price">price parameter</param>
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
        /// <summary>
        /// the calories based on the size of the food
        /// </summary>
        /// <param name="size">size parameter</param>
        /// <param name="calories">calories parameter</param>
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
        /// <summary>
        /// returning correct string based on the size
        /// </summary>
        /// <param name="size">size parameter</param>
        /// <param name="name">name parameter</param>
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
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesSizeProperty(Size size)
        {
            DragonbornWaffleFries dj = new DragonbornWaffleFries();
            Assert.PropertyChanged(dj, "Size", () => dj.Size = size);
        }

    }
}
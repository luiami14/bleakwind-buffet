/*
 * Author: Luis Amiel
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Interface;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class SailorSodaTests
    {
        /// <summary>
        /// A test that tests if it should be a drink
        /// </summary>
        [Fact]
        public void ShouldBeADrink()
        {
            SailorSoda sj = new SailorSoda();
            Assert.IsAssignableFrom<Drink>(sj);
        }
        /// <summary>
        /// A test that tests if it should be a orderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            SailorSoda sj = new SailorSoda();
            Assert.IsAssignableFrom<IOrderItem>(sj);
        }
        /// <summary>
        /// include ice by default
        /// </summary>
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            SailorSoda sj = new SailorSoda();
            Assert.True(sj.Ice);
        }
        /// <summary>
        /// small by default 
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            SailorSoda sj = new SailorSoda();
            Assert.Equal(Size.Small, sj.Size);
        }
        /// <summary>
        /// cherry flavor by default
        /// </summary>
        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            SailorSoda sj = new SailorSoda();
            Assert.Equal(SodaFlavor.Cherry, sj.Flavor);
        }
        /// <summary>
        /// set to ice
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            SailorSoda sj = new SailorSoda();
            sj.Ice = true;
            Assert.True(sj.Ice);
            sj.Ice = false;
            Assert.False(sj.Ice);
        }
        /// <summary>
        /// setting to size
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            SailorSoda sj = new SailorSoda();
            sj.Size = Size.Large;
            Assert.Equal(Size.Large, sj.Size);
            sj.Size = Size.Medium;
            Assert.Equal(Size.Medium, sj.Size);
            sj.Size = Size.Small;
            Assert.Equal(Size.Small, sj.Size);
        }
        /// <summary>
        /// setting to a flavor
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {

            SailorSoda sj = new SailorSoda();
            sj.Flavor = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, sj.Flavor);
            sj.Flavor = SodaFlavor.Cherry;
            Assert.Equal(SodaFlavor.Cherry, sj.Flavor);
            sj.Flavor = SodaFlavor.Grapefruit;
            Assert.Equal(SodaFlavor.Grapefruit, sj.Flavor);
            sj.Flavor = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, sj.Flavor);
            sj.Flavor = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, sj.Flavor);
            sj.Flavor = SodaFlavor.Watermelon;
            Assert.Equal(SodaFlavor.Watermelon, sj.Flavor);
        }
        /// <summary>
        /// correct price for size
        /// </summary>
        /// <param name="size">size parameter</param>
        /// <param name="price">price parameter</param>
        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            SailorSoda sj = new SailorSoda();
            sj.Size = size;
            Assert.Equal(price, sj.Price);
        }
        /// <summary>
        /// correct calories for the size
        /// </summary>
        /// <param name="size">size parameter</param>
        /// <param name="cal">calories parameter</param>
        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            SailorSoda sj = new SailorSoda();
            sj.Size = size;
            Assert.Equal(cal, sj.Calories);
        }
        /// <summary>
        /// correct special instructions 
        /// </summary>
        /// <param name="includeIce">ice parameter</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            SailorSoda sj = new SailorSoda();
            sj.Ice = includeIce;
            if (!includeIce) Assert.Contains("Hold ice", sj.SpecialInstructions);
            else Assert.Empty(sj.SpecialInstructions);
        }
        /// <summary>
        /// correct toString based on size and flavor
        /// </summary>
        /// <param name="flavor">flavor parameter</param>
        /// <param name="size">size parameter</param>
        /// <param name="name">name parameter</param>
        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            SailorSoda sj = new SailorSoda();
            sj.Size = size;
            sj.Flavor = flavor;
            Assert.Equal(sj.ToString(), name);
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesSizeProperty(Size size)
        {
            SailorSoda sj = new SailorSoda();
            Assert.PropertyChanged(sj, "Size", () => sj.Size = size);
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesPriceProperty(Size size)
        {
            SailorSoda sj = new SailorSoda();
            Assert.PropertyChanged(sj, "Price", () => sj.Size = size);
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesCaloriesProperty(Size size)
        {
            SailorSoda sj = new SailorSoda();
            Assert.PropertyChanged(sj, "Calories", () => sj.Size = size);
        }
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingIceNotifiesIceProperty(bool ice)
        {
            SailorSoda sj = new SailorSoda();
            Assert.PropertyChanged(sj, "Ice", () => sj.Ice = ice);
            Assert.PropertyChanged(sj, "SpecialInstructions", () => sj.Ice = ice);
        }
        [Fact]
        public void ImplementsINotifyPropertyChange()
        {
            SailorSoda sj = new SailorSoda();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(sj);
        }
    }
}

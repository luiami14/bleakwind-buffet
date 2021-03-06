﻿/*
 * Author: Luis Amiel
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Interface;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Theory]
        [InlineData("Hormone-free organic 2% milk.")]
        public void ChecksAllEntreeDescriptions(string name)
        {
            MarkarthMilk mj = new MarkarthMilk();
            Assert.Equal(name, mj.Description);
            Assert.Equal("Drink", mj.Category);
        }
        /// <summary>
        /// A test that tests if it should be a drink
        /// </summary>
        [Fact]
        public void ShouldBeADrink()
        {
            MarkarthMilk mj = new MarkarthMilk();
            Assert.IsAssignableFrom<Drink>(mj);
        }
        /// <summary>
        /// A test that tests if it should be a orderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            MarkarthMilk mj = new MarkarthMilk();
            Assert.IsAssignableFrom<IOrderItem>(mj);
        }
        /// <summary>
        /// not include ice by default
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            MarkarthMilk mj = new MarkarthMilk();
            Assert.False(mj.Ice);
        }
        /// <summary>
        /// small by default
        /// </summary>
        [Fact]
        public void ShouldBySmallByDefault()
        {
            MarkarthMilk mj = new MarkarthMilk();
            Assert.Equal(Size.Small, mj.Size);
        }
        /// <summary>
        /// set ice
        /// </summary>
        [Fact]
        public void ShouldByAbleToSetIce()
        {
            MarkarthMilk mj = new MarkarthMilk();
            mj.Ice = true;
            Assert.True(mj.Ice);
            mj.Ice = false;
            Assert.False(mj.Ice);
        }
        /// <summary>
        /// able to set to ice
        /// </summary>
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
        /// <summary>
        /// correct price for the size
        /// </summary>
        /// <param name="size">size parameter</param>
        /// <param name="price">price parameter</param>
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
        /// <summary>
        /// correct calories for the size
        /// </summary>
        /// <param name="size">size parameter</param>
        /// <param name="cal">calories parameter</param>
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
        /// <summary>
        /// correct special instructions
        /// </summary>
        /// <param name="includeIce">ice parameter</param>
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
        /// <summary>
        /// correct tostring based on the size
        /// </summary>
        /// <param name="size"></param>
        /// <param name="name"></param>
        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk mj = new MarkarthMilk();
            mj.Size = size;
            Assert.Equal(mj.ToString(), name);
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesSizeProperty(Size size)
        {
            MarkarthMilk mj = new MarkarthMilk();
            Assert.PropertyChanged(mj, "Size", () => mj.Size = size);
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesCaloriesProperty(Size size)
        {
            MarkarthMilk mj = new MarkarthMilk();
            Assert.PropertyChanged(mj, "Calories", () => mj.Size = size);
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesPriceProperty(Size size)
        {
            MarkarthMilk mj = new MarkarthMilk();
            Assert.PropertyChanged(mj, "Price", () => mj.Size = size);
        }
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingIceNotifiesIceProperty(bool ice)
        {
            MarkarthMilk mj = new MarkarthMilk();
            Assert.PropertyChanged(mj, "Ice", () => mj.Ice = ice);
            Assert.PropertyChanged(mj, "SpecialInstructions", () => mj.Ice = ice);
        }
        [Fact]
        public void ImplementsINotifyPropertyChange()
        {
            MarkarthMilk mj = new MarkarthMilk();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(mj);
        }
    }
}
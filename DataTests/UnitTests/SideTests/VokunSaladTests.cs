/*
 * Author: Luis Amiel
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Interface;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class VokunSaladTests
    {
        /// <summary>
        /// A test that tests if it should be a Side
        /// </summary>
        [Fact]
        public void ShouldBeASide()
        {
            VokunSalad vj = new VokunSalad();
            Assert.IsAssignableFrom<Side>(vj);
        }
        /// <summary>
        /// A test that tests if it should be a orderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            VokunSalad vj = new VokunSalad();
            Assert.IsAssignableFrom<IOrderItem>(vj);
        }
        /// <summary>
        /// small by default 
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            VokunSalad vj = new VokunSalad();
            Assert.Equal(Size.Small, vj.Size);
        }
        /// <summary>
        /// able to set any size
        /// </summary>
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
        /// <summary>
        /// returns special instructions 
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            VokunSalad vj = new VokunSalad();
            Assert.Empty(vj.SpecialInstructions);
        }
        /// <summary>
        /// returns price based on the size
        /// </summary>
        /// <param name="size">size parameter</param>
        /// <param name="price">price parameter</param>
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
        /// <summary>
        /// correct calories based on the size
        /// </summary>
        /// <param name="size">size parameter</param>
        /// <param name="calories">calories parameter</param>
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
        /// <summary>
        /// correct spring based on the size
        /// </summary>
        /// <param name="size">size parameter</param>
        /// <param name="name">name parameter</param>
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
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesSizeProperty(Size size)
        {
            VokunSalad vj = new VokunSalad();
            Assert.PropertyChanged(vj, "Size", () => vj.Size = size);
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesCaloriesProperty(Size size)
        {
            VokunSalad vj = new VokunSalad();
            Assert.PropertyChanged(vj, "Calories", () => vj.Size = size);
        }
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeNotifiesPriceProperty(Size size)
        {
            VokunSalad vj = new VokunSalad();
            Assert.PropertyChanged(vj, "Price", () => vj.Size = size);
        }
        [Fact]
        public void ImplementsINotifyPropertyChange()
        {
            VokunSalad vj = new VokunSalad();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(vj);
        }
    }
}
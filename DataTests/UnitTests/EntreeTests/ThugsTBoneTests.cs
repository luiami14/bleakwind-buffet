/*
 * Author: Luis Amiel
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interface;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        /// <summary>
        /// A test that tests if it should be a entree
        /// </summary>
        [Fact]
        public void ShouldBeAEntree()
        {
            ThugsTBone tj = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(tj);
        }
        /// <summary>
        /// A test that tests if it should be a orderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            ThugsTBone tj = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(tj);
        }
        /// <summary>
        /// returns correct price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone tj = new ThugsTBone();
            Assert.Equal(6.44, tj.Price);
        }
        /// <summary>
        /// returns correct calories
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone tj = new ThugsTBone();
            Assert.Equal((uint)982, tj.Calories);
        }
        /// <summary>
        /// returns special instructions 
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone tj = new ThugsTBone();
            Assert.Empty(tj.SpecialInstructions);
        }
        /// <summary>
        /// returns correct toString()
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone tj = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", tj.ToString());
        }
        [Fact]
        public void ImplementsINotifyPropertyChange()
        {
            ThugsTBone tj = new ThugsTBone();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(tj);
        }
    }
}
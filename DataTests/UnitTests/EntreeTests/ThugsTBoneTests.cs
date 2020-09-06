/*
 * Author: Luis Amiel
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
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
    }
}
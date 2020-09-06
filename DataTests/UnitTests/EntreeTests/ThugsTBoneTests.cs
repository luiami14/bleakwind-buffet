﻿/*
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
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone tj = new ThugsTBone();
            Assert.Equal(6.44, tj.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone tj = new ThugsTBone();
            Assert.Equal((uint)982, tj.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone tj = new ThugsTBone();
            Assert.Empty(tj.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone tj = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", tj.ToString());
        }
    }
}
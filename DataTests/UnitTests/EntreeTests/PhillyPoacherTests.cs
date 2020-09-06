/*
 * Author: Luis Amiel
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher pj = new PhillyPoacher();
            Assert.True(pj.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher pj = new PhillyPoacher();
            Assert.True(pj.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher pj = new PhillyPoacher();
            Assert.True(pj.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher pj = new PhillyPoacher();
            pj.Sirloin = true;
            Assert.True(pj.Sirloin);
            pj.Sirloin = false;
            Assert.False(pj.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher pj = new PhillyPoacher();
            pj.Onion = true;
            Assert.True(pj.Onion);
            pj.Onion = false;
            Assert.False(pj.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher pj = new PhillyPoacher();
            pj.Roll = true;
            Assert.True(pj.Roll);
            pj.Roll = false;
            Assert.False(pj.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
        }
    }
}
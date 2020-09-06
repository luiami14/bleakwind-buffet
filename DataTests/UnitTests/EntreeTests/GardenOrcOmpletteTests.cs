/*
 * Author: Luis Amiel
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette gj = new GardenOrcOmelette();
            Assert.True(gj.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette gj = new GardenOrcOmelette();
            Assert.True(gj.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette gj = new GardenOrcOmelette();
            Assert.True(gj.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette gj = new GardenOrcOmelette();
            Assert.True(gj.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette gj = new GardenOrcOmelette();
            gj.Broccoli = true;
            Assert.True(gj.Broccoli);
            gj.Broccoli = false;
            Assert.False(gj.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette gj = new GardenOrcOmelette();
            gj.Mushrooms = true;
            Assert.True(gj.Mushrooms);
            gj.Mushrooms = false;
            Assert.False(gj.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette gj = new GardenOrcOmelette();
            gj.Tomato = true;
            Assert.True(gj.Tomato);
            gj.Tomato = false;
            Assert.False(gj.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette gj = new GardenOrcOmelette();
            gj.Cheddar = true;
            Assert.True(gj.Cheddar);
            gj.Cheddar = false;
            Assert.False(gj.Cheddar);
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
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
        }
    }
}
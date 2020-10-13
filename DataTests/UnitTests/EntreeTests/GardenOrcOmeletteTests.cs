/*
 * Author: Luis Amiel
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interface;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        /// <summary>
        /// A test that tests if it should be a entree
        /// </summary>
        [Fact]
        public void ShouldBeAEntree()
        {
            GardenOrcOmelette gj = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(gj);
        }
        /// <summary>
        /// A test that tests if it should be a orderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            GardenOrcOmelette gj = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(gj);
        }
        /// <summary>
        /// includes broccoli by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette gj = new GardenOrcOmelette();
            Assert.True(gj.Broccoli);
        }
        /// <summary>
        /// includes mushrooms by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette gj = new GardenOrcOmelette();
            Assert.True(gj.Mushrooms);
        }
        /// <summary>
        /// includes tomato by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette gj = new GardenOrcOmelette();
            Assert.True(gj.Tomato);
        }
        /// <summary>
        /// includes cheddar by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette gj = new GardenOrcOmelette();
            Assert.True(gj.Cheddar);
        }
        /// <summary>
        /// sets the broccoli
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette gj = new GardenOrcOmelette();
            gj.Broccoli = true;
            Assert.True(gj.Broccoli);
            gj.Broccoli = false;
            Assert.False(gj.Broccoli);
        }
        /// <summary>
        /// sets the mushrooms
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette gj = new GardenOrcOmelette();
            gj.Mushrooms = true;
            Assert.True(gj.Mushrooms);
            gj.Mushrooms = false;
            Assert.False(gj.Mushrooms);
        }
        /// <summary>
        /// sets the tomato
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette gj = new GardenOrcOmelette();
            gj.Tomato = true;
            Assert.True(gj.Tomato);
            gj.Tomato = false;
            Assert.False(gj.Tomato);
        }
        /// <summary>
        /// sets the cheddar
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette gj = new GardenOrcOmelette();
            gj.Cheddar = true;
            Assert.True(gj.Cheddar);
            gj.Cheddar = false;
            Assert.False(gj.Cheddar);
        }
        /// <summary>
        /// returns the correct price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette gj = new GardenOrcOmelette();
            Assert.Equal(4.57, gj.Price);
        }
        /// <summary>
        /// returns the correct calories
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette gj = new GardenOrcOmelette();
            Assert.Equal((uint)404, gj.Calories);
        }
        /// <summary>
        /// shoudl return special instractions
        /// </summary>
        /// <param name="includeBroccoli">broccoli parameter</param>
        /// <param name="includeMushrooms">mushroom parameter</param>
        /// <param name="includeTomato">tomato parameter</param>
        /// <param name="includeCheddar">cheddar parameter</param>
        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette gj = new GardenOrcOmelette();
            gj.Broccoli = includeBroccoli;
            gj.Mushrooms = includeMushrooms;
            gj.Tomato = includeTomato;
            gj.Cheddar = includeCheddar;
            if (!includeBroccoli) Assert.Contains("Hold broccoli", gj.SpecialInstructions);
            if (!includeMushrooms) Assert.Contains("Hold mushrooms", gj.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", gj.SpecialInstructions);
            if (!includeCheddar) Assert.Contains("Hold cheddar", gj.SpecialInstructions);
            if (includeBroccoli && includeMushrooms && includeTomato && includeCheddar) Assert.Empty(gj.SpecialInstructions);
        }
        /// <summary>
        /// returns the correct string
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette gj = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", gj.ToString());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingBroccoliNotifiesBroccoliProperty(bool broccoli)
        {
            GardenOrcOmelette gj = new GardenOrcOmelette();
            Assert.PropertyChanged(gj, "Broccoli", () => gj.Broccoli = broccoli);
            Assert.PropertyChanged(gj, "SpecialInstructions", () => gj.Broccoli = broccoli);
        }
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingMushroomsNotifiesMushroomsProperty(bool mushrooms)
        {
            GardenOrcOmelette gj = new GardenOrcOmelette();
            Assert.PropertyChanged(gj, "Mushrooms", () => gj.Mushrooms = mushrooms);
            Assert.PropertyChanged(gj, "SpecialInstructions", () => gj.Mushrooms = mushrooms);
        }
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingTomatoNotifiesTomatoProperty(bool tomato)
        {
            GardenOrcOmelette gj = new GardenOrcOmelette();
            Assert.PropertyChanged(gj, "Tomato", () => gj.Tomato = tomato);
            Assert.PropertyChanged(gj, "SpecialInstructions", () => gj.Tomato = tomato);
        }
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingCheddarNotifiesCheddarProperty(bool cheddar)
        {
            GardenOrcOmelette gj = new GardenOrcOmelette();
            Assert.PropertyChanged(gj, "Cheddar", () => gj.Cheddar = cheddar);
            Assert.PropertyChanged(gj, "SpecialInstructions", () => gj.Cheddar = cheddar);
        }
        [Fact]
        public void ImplementsINotifyPropertyChange()
        {
            GardenOrcOmelette gj = new GardenOrcOmelette();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(gj);
        }
    }
}
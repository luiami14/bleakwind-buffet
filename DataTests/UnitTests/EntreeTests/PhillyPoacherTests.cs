/*
 * Author: Luis Amiel
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interface;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Theory]
        [InlineData("Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.")]
        public void ChecksAllEntreeDescriptions(string name)
        {
            PhillyPoacher pj = new PhillyPoacher();
            Assert.Equal(name, pj.Description);
            Assert.Equal("Entree", pj.Category);
        }
        /// <summary>
        /// A test that tests if it should be a entree
        /// </summary>
        [Fact]
        public void ShouldBeAEntree()
        {
            PhillyPoacher pj = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(pj);
        }
        /// <summary>
        /// A test that tests if it should be a orderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            PhillyPoacher pj = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(pj);
        }
        /// <summary>
        /// includes sirloin by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher pj = new PhillyPoacher();
            Assert.True(pj.Sirloin);
        }
        /// <summary>
        /// should include onion by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher pj = new PhillyPoacher();
            Assert.True(pj.Onion);
        }
        /// <summary>
        /// includes roll by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher pj = new PhillyPoacher();
            Assert.True(pj.Roll);
        }
        /// <summary>
        /// sets sirloin
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher pj = new PhillyPoacher();
            pj.Sirloin = true;
            Assert.True(pj.Sirloin);
            pj.Sirloin = false;
            Assert.False(pj.Sirloin);
        }
        /// <summary>
        /// setting the onions
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher pj = new PhillyPoacher();
            pj.Onion = true;
            Assert.True(pj.Onion);
            pj.Onion = false;
            Assert.False(pj.Onion);
        }
        /// <summary>
        /// setting the roll
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher pj = new PhillyPoacher();
            pj.Roll = true;
            Assert.True(pj.Roll);
            pj.Roll = false;
            Assert.False(pj.Roll);
        }
        /// <summary>
        /// returns the correct price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher pj = new PhillyPoacher();
            Assert.Equal(7.23, pj.Price);
        }
        /// <summary>
        /// returns the correct calories
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher pj = new PhillyPoacher();
            Assert.Equal((uint)784, pj.Calories);
        }
        /// <summary>
        /// returns the special instructions
        /// </summary>
        /// <param name="includeSirloin">sirloin parameter</param>
        /// <param name="includeOnion">onion parameter</param>
        /// <param name="includeRoll">roll parameter</param>
        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher pj = new PhillyPoacher();
            pj.Sirloin = includeSirloin;
            pj.Onion = includeOnion;
            pj.Roll = includeRoll;
            if(!includeSirloin) Assert.Contains("Hold sirloin", pj.SpecialInstructions);
            if (!includeOnion) Assert.Contains("Hold onions", pj.SpecialInstructions);
            if (!includeRoll) Assert.Contains("Hold roll", pj.SpecialInstructions);
            if (includeRoll && includeOnion && includeSirloin) Assert.Empty(pj.SpecialInstructions);
        }
        /// <summary>
        /// returns the correct to string
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher pj = new PhillyPoacher();
            Assert.Equal("Philly Poacher", pj.ToString());
        }
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingSirloinNotifiesSirloinProperty(bool sirloin)
        {
            PhillyPoacher pj = new PhillyPoacher();
            Assert.PropertyChanged(pj, "Sirloin", () => pj.Sirloin = sirloin);
            Assert.PropertyChanged(pj, "SpecialInstructions", () => pj.Sirloin = sirloin);
        }
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingOnionNotifiesOnionProperty(bool onion)
        {
            PhillyPoacher pj = new PhillyPoacher();
            Assert.PropertyChanged(pj, "Onion", () => pj.Onion = onion);
            Assert.PropertyChanged(pj, "SpecialInstructions", () => pj.Onion = onion);
        }
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingRollNotifiesRollProperty(bool roll)
        {
            PhillyPoacher pj = new PhillyPoacher();
            Assert.PropertyChanged(pj, "Roll", () => pj.Roll = roll);
            Assert.PropertyChanged(pj, "SpecialInstructions", () => pj.Roll = roll);
        }
        [Fact]
        public void ImplementsINotifyPropertyChange()
        {
            PhillyPoacher pj = new PhillyPoacher();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(pj);
        }
    }
}
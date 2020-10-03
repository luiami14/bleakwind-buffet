/*
 * Author: Luis Amiel
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interface;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {
        /// <summary>
        /// A test that tests if it should be a entree
        /// </summary>
        [Fact]
        public void ShouldBeAEntree()
        {
            SmokehouseSkeleton sj = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(sj);
        }
        /// <summary>
        /// A test that tests if it should be a orderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            SmokehouseSkeleton sj = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(sj);
        }
        /// <summary>
        /// includes sausage by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton sj = new SmokehouseSkeleton();
            Assert.True(sj.SausageLink);
        }
        /// <summary>
        /// includes eggs by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton sj = new SmokehouseSkeleton();
            Assert.True(sj.Egg);
        }
        /// <summary>
        /// includes hashbrowns by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton sj = new SmokehouseSkeleton();
            Assert.True(sj.HashBrowns);
        }
        /// <summary>
        /// includes pancakes by default
        /// </summary>
        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton sj = new SmokehouseSkeleton();
            Assert.True(sj.Pancake);
        }
        /// <summary>
        /// sets to sausage
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton sj = new SmokehouseSkeleton();
            sj.SausageLink = true;
            Assert.True(sj.SausageLink);
            sj.SausageLink = false;
            Assert.False(sj.SausageLink);
        }
        /// <summary>
        /// sets to eggs
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton sj = new SmokehouseSkeleton();
            sj.Egg = true;
            Assert.True(sj.Egg);
            sj.Egg = false;
            Assert.False(sj.Egg);
        }
        /// <summary>
        /// sets to hashbrowns
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton sj = new SmokehouseSkeleton();
            sj.HashBrowns = true;
            Assert.True(sj.HashBrowns);
            sj.HashBrowns = false;
            Assert.False(sj.HashBrowns);
        }
        /// <summary>
        /// sets to pancakes
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton sj = new SmokehouseSkeleton();
            sj.Pancake = true;
            Assert.True(sj.Pancake);
            sj.Pancake = false;
            Assert.False(sj.Pancake);
        }
        /// <summary>
        /// returns the correct price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton sj = new SmokehouseSkeleton();
            Assert.Equal(5.62, sj.Price);
        }
        /// <summary>
        /// returns the correct calories
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton sj = new SmokehouseSkeleton();
            Assert.Equal((uint)602, sj.Calories);
        }
        /// <summary>
        /// returns the correct special instructions
        /// </summary>
        /// <param name="includeSausage">sausage parameter</param>
        /// <param name="includeEgg">egg parameter</param>
        /// <param name="includeHashbrowns">hashbrown parameter</param>
        /// <param name="includePancake">pancake parameter</param>
        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton sj = new SmokehouseSkeleton();
            sj.SausageLink = includeSausage;
            sj.Egg = includeEgg;
            sj.HashBrowns = includeHashbrowns;
            sj.Pancake = includePancake;
            if (!includeSausage) Assert.Contains("Hold sausage", sj.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold eggs", sj.SpecialInstructions);
            if (!includeHashbrowns) Assert.Contains("Hold hash browns", sj.SpecialInstructions);
            if (!includePancake) Assert.Contains("Hold pancakes", sj.SpecialInstructions);
            if (includeSausage && includeEgg && includeHashbrowns && includePancake) Assert.Empty(sj.SpecialInstructions);
        }
        /// <summary>
        /// returns the correct toString()
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton sj = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", sj.ToString());
        }
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingSausageNotifiesSausageProperty(bool sausage)
        {
            SmokehouseSkeleton sj = new SmokehouseSkeleton();
            Assert.PropertyChanged(sj, "SausageLink", () => sj.SausageLink = sausage);
        }
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingEggNotifiesEggProperty(bool egg)
        {
            SmokehouseSkeleton sj = new SmokehouseSkeleton();
            Assert.PropertyChanged(sj, "Egg", () => sj.Egg = egg);
        }
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingHashBrownsNotifiesHashBrownsProperty(bool hashbrowns)
        {
            SmokehouseSkeleton sj = new SmokehouseSkeleton();
            Assert.PropertyChanged(sj, "HashBrowns", () => sj.HashBrowns = hashbrowns);
        }
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingPancakesNotifiesPancakesProperty(bool pancake)
        {
            SmokehouseSkeleton sj = new SmokehouseSkeleton();
            Assert.PropertyChanged(sj, "Pancake", () => sj.Pancake = pancake);
        }
    }
}
/*
 * Author: Luis Amiel
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {        
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton sj = new SmokehouseSkeleton();
            Assert.True(sj.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton sj = new SmokehouseSkeleton();
            Assert.True(sj.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton sj = new SmokehouseSkeleton();
            Assert.True(sj.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton sj = new SmokehouseSkeleton();
            Assert.True(sj.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton sj = new SmokehouseSkeleton();
            sj.SausageLink = true;
            Assert.True(sj.SausageLink);
            sj.SausageLink = false;
            Assert.False(sj.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton sj = new SmokehouseSkeleton();
            sj.Egg = true;
            Assert.True(sj.Egg);
            sj.Egg = false;
            Assert.False(sj.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton sj = new SmokehouseSkeleton();
            sj.HashBrowns = true;
            Assert.True(sj.HashBrowns);
            sj.HashBrowns = false;
            Assert.False(sj.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton sj = new SmokehouseSkeleton();
            sj.Pancake = true;
            Assert.True(sj.Pancake);
            sj.Pancake = false;
            Assert.False(sj.Pancake);
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
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
        }
    }
}
/*
 * Author: Zachery Brunner
 * Class: WarriorWaterTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            WarriorWater wj = new WarriorWater();
            Assert.False(wj.Ice);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            WarriorWater wj = new WarriorWater();
            wj.Ice = true;
            Assert.True(wj.Ice);
            wj.Ice = false;
            Assert.False(wj.Ice);
        }

    }
}

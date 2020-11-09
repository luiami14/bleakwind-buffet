/*
 * Author: Luis Amiel
 * Class name: MenuTests.cs
 * Purpose: A test class for the menu class
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interface;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using Xunit;
using BleakwindBuffet.Data.Menu;


namespace BleakwindBuffet.DataTests.UnitTests.MenuTests
{
    public class MenuTests
    {
        /// <summary>
        /// Test that the menu returns all of the entrees
        /// </summary>
        [Fact]
        public void MenuReturnsAllEntrees()
        {
            Assert.Contains(Menu.Entrees(), (item) => { return item is BriarheartBurger; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is DoubleDraugr; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is GardenOrcOmelette; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is PhillyPoacher; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is SmokehouseSkeleton; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is ThalmorTriple; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is ThugsTBone; });
            Assert.Contains(Menu.FullMenu(), (item) => { return item is BriarheartBurger; });
            Assert.Contains(Menu.FullMenu(), (item) => { return item is DoubleDraugr; });
            Assert.Contains(Menu.FullMenu(), (item) => { return item is GardenOrcOmelette; });
            Assert.Contains(Menu.FullMenu(), (item) => { return item is PhillyPoacher; });
            Assert.Contains(Menu.FullMenu(), (item) => { return item is SmokehouseSkeleton; });
            Assert.Contains(Menu.FullMenu(), (item) => { return item is ThalmorTriple; });
            Assert.Contains(Menu.FullMenu(), (item) => { return item is ThugsTBone; });
        }
        /// <summary>
        /// Test that the menu returns all of the drinks
        /// </summary>
        /// <param name="name">the name parameter</param>
        [Theory]
        [InlineData("Small Warrior Water")]
        [InlineData("Medium Warrior Water")]
        [InlineData("Large Warrior Water")]

        [InlineData("Small Watermelon Sailor Soda")]
        [InlineData("Medium Watermelon Sailor Soda")]
        [InlineData("Large Watermelon Sailor Soda")]

        [InlineData("Small Blackberry Sailor Soda")]
        [InlineData("Medium Blackberry Sailor Soda")]
        [InlineData("Large Blackberry Sailor Soda")]

        [InlineData("Small Cherry Sailor Soda")]
        [InlineData("Medium Cherry Sailor Soda")]
        [InlineData("Large Cherry Sailor Soda")]

        [InlineData("Small Grapefruit Sailor Soda")]
        [InlineData("Medium Grapefruit Sailor Soda")]
        [InlineData("Large Grapefruit Sailor Soda")]

        [InlineData("Small Lemon Sailor Soda")]
        [InlineData("Medium Lemon Sailor Soda")]
        [InlineData("Large Lemon Sailor Soda")]

        [InlineData("Small Peach Sailor Soda")]
        [InlineData("Medium Peach Sailor Soda")]
        [InlineData("Large Peach Sailor Soda")]

        [InlineData("Small Candlehearth Coffee")]
        [InlineData("Medium Candlehearth Coffee")]
        [InlineData("Large Candlehearth Coffee")]

        [InlineData("Small Aretino Apple Juice")]
        [InlineData("Medium Aretino Apple Juice")]
        [InlineData("Large Aretino Apple Juice")]

        [InlineData("Small Markarth Milk")]
        [InlineData("Medium Markarth Milk")]
        [InlineData("Large Markarth Milk")]
        public void ReturnsAllDrinks(string name)
        {
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals(name); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals(name); });
            Assert.Contains(Menu.Search(null), (item) => { return item.ToString().Equals(name); });
        }
        /// <summary>
        /// Test that the menu returns all of the sides
        /// </summary>
        /// <param name="name">the name parameter</param>
        [Theory]
        [InlineData("Small Vokun Salad")]
        [InlineData("Medium Vokun Salad")]
        [InlineData("Large Vokun Salad")]

        [InlineData("Small Fried Miraak")]
        [InlineData("Medium Fried Miraak")]
        [InlineData("Large Fried Miraak")]

        [InlineData("Small Dragonborn Waffle Fries")]
        [InlineData("Medium Dragonborn Waffle Fries")]
        [InlineData("Large Dragonborn Waffle Fries")]

        [InlineData("Small Mad Otar Grits")]
        [InlineData("Medium Mad Otar Grits")]
        [InlineData("Large Mad Otar Grits")]
        public void ReturnsAllSides(string name)
        {
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals(name); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals(name); });
            Assert.Contains(Menu.Search(null), (item) => { return item.ToString().Equals(name); });
        }
        [Fact]
        public void PriceHasToBeOverZeroAndLessThanTen()
        {
            IEnumerable<IOrderItem> list = Menu.FilterByPrice(Menu.FullMenu(), 0.01, 10);
            Assert.Contains(list, item => item.ToString().Contains("Briarheart Burger"));
            Assert.Contains(list, item => item.ToString().Contains("Double Draugr"));
            Assert.Contains(list, item => item.ToString().Contains("Garden Orc Omelette"));
            Assert.Contains(list, item => item.ToString().Contains("Philly Poacher"));
            Assert.Contains(list, item => item.ToString().Contains("Smokehouse Skeleton"));
            Assert.Contains(list, item => item.ToString().Contains("Thalmor Triple"));
            Assert.Contains(list, item => item.ToString().Contains("Thugs T-Bone"));
        }
        [Fact]
        public void CaloriesHasToBeOverZeroAndLessThanAThousand()
        {
            IEnumerable<IOrderItem> list = Menu.FilterByCalories(Menu.FullMenu(), 1, 1000);
            Assert.Contains(list, item => item.ToString().Contains("Briarheart Burger"));
            Assert.Contains(list, item => item.ToString().Contains("Double Draugr"));
            Assert.Contains(list, item => item.ToString().Contains("Garden Orc Omelette"));
            Assert.Contains(list, item => item.ToString().Contains("Philly Poacher"));
            Assert.Contains(list, item => item.ToString().Contains("Smokehouse Skeleton"));
            Assert.Contains(list, item => item.ToString().Contains("Thalmor Triple"));
            Assert.Contains(list, item => item.ToString().Contains("Thugs T-Bone"));
        }
        [Fact]
        public void ChecksIfMinCaloriesEqualNull()
        {
            IEnumerable<IOrderItem> list = Menu.FilterByCalories(Menu.FullMenu(), null, 1000);
            Assert.Contains(list, item => item.ToString().Contains("Briarheart Burger"));
            Assert.Contains(list, item => item.ToString().Contains("Double Draugr"));
            Assert.Contains(list, item => item.ToString().Contains("Garden Orc Omelette"));
            Assert.Contains(list, item => item.ToString().Contains("Philly Poacher"));
            Assert.Contains(list, item => item.ToString().Contains("Smokehouse Skeleton"));
            Assert.Contains(list, item => item.ToString().Contains("Thalmor Triple"));
            Assert.Contains(list, item => item.ToString().Contains("Thugs T-Bone"));
        }
        [Fact]
        public void ChecksIfMaxCaloriesEqualNull()
        {
            IEnumerable<IOrderItem> list = Menu.FilterByCalories(Menu.FullMenu(), 1, null);
            Assert.Contains(list, item => item.ToString().Contains("Briarheart Burger"));
            Assert.Contains(list, item => item.ToString().Contains("Double Draugr"));
            Assert.Contains(list, item => item.ToString().Contains("Garden Orc Omelette"));
            Assert.Contains(list, item => item.ToString().Contains("Philly Poacher"));
            Assert.Contains(list, item => item.ToString().Contains("Smokehouse Skeleton"));
            Assert.Contains(list, item => item.ToString().Contains("Thalmor Triple"));
            Assert.Contains(list, item => item.ToString().Contains("Thugs T-Bone"));
        }
        [Fact]
        public void ChecksIfCaloriesEqualNull()
        {
            IEnumerable<IOrderItem> list = Menu.FilterByCalories(Menu.FullMenu(), null, null);
            Assert.Contains(list, item => item.ToString().Contains("Briarheart Burger"));
            Assert.Contains(list, item => item.ToString().Contains("Double Draugr"));
            Assert.Contains(list, item => item.ToString().Contains("Garden Orc Omelette"));
            Assert.Contains(list, item => item.ToString().Contains("Philly Poacher"));
            Assert.Contains(list, item => item.ToString().Contains("Smokehouse Skeleton"));
            Assert.Contains(list, item => item.ToString().Contains("Thalmor Triple"));
            Assert.Contains(list, item => item.ToString().Contains("Thugs T-Bone"));
        }
        [Fact]
        public void ChecksIfMinPriceEqualNull()
        {
            IEnumerable<IOrderItem> list = Menu.FilterByPrice(Menu.FullMenu(), null, 10);
            Assert.Contains(list, item => item.ToString().Contains("Briarheart Burger"));
            Assert.Contains(list, item => item.ToString().Contains("Double Draugr"));
            Assert.Contains(list, item => item.ToString().Contains("Garden Orc Omelette"));
            Assert.Contains(list, item => item.ToString().Contains("Philly Poacher"));
            Assert.Contains(list, item => item.ToString().Contains("Smokehouse Skeleton"));
            Assert.Contains(list, item => item.ToString().Contains("Thalmor Triple"));
            Assert.Contains(list, item => item.ToString().Contains("Thugs T-Bone"));
        }
        [Fact]
        public void ChecksIfMaxPriceEqualNull()
        {
            IEnumerable<IOrderItem> list = Menu.FilterByPrice(Menu.FullMenu(), 0.01, null);
            Assert.Contains(list, item => item.ToString().Contains("Briarheart Burger"));
            Assert.Contains(list, item => item.ToString().Contains("Double Draugr"));
            Assert.Contains(list, item => item.ToString().Contains("Garden Orc Omelette"));
            Assert.Contains(list, item => item.ToString().Contains("Philly Poacher"));
            Assert.Contains(list, item => item.ToString().Contains("Smokehouse Skeleton"));
            Assert.Contains(list, item => item.ToString().Contains("Thalmor Triple"));
            Assert.Contains(list, item => item.ToString().Contains("Thugs T-Bone"));
        }
        [Fact]
        public void ChecksIfPriceEqualNull()
        {
            IEnumerable<IOrderItem> list = Menu.FilterByPrice(Menu.FullMenu(), null, null);
            Assert.Contains(list, item => item.ToString().Contains("Briarheart Burger"));
            Assert.Contains(list, item => item.ToString().Contains("Double Draugr"));
            Assert.Contains(list, item => item.ToString().Contains("Garden Orc Omelette"));
            Assert.Contains(list, item => item.ToString().Contains("Philly Poacher"));
            Assert.Contains(list, item => item.ToString().Contains("Smokehouse Skeleton"));
            Assert.Contains(list, item => item.ToString().Contains("Thalmor Triple"));
            Assert.Contains(list, item => item.ToString().Contains("Thugs T-Bone"));
        }
    }
}

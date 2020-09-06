/*
 * Author: Luis Amiel
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent one of the drinks in the menu
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee
    {
        /// <summary>
        /// private variable that initializes the size
        /// </summary>
        private Size size = Size.Small;
        /// <summary>
        /// Provides available sizes
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }

        }
        /// <summary>
        /// Price of the coffee
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 0.75;
                }
                else if (size == Size.Medium)
                {
                    return 1.25;
                }
                else if (size == Size.Large)
                {
                    return 1.75;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// Gets the calories of coffee
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 7;
                }
                else if (size == Size.Medium)
                {
                    return 10;
                }
                else if (size == Size.Large)
                {
                    return 20;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// This method just prints out the name of the drink
        /// </summary>
        /// <returns>returns the name of the drink</returns>
        public override string ToString()
        {
            if(Decaf == true)
            {
                return size.ToString()+ " Decaf Candlehearth Coffee";
            }
            else
            {
                return size.ToString() + " Candlehearth Coffee";
            }
        }
        /// <summary>
        /// This method makes a new List everytime a user is odering this drink
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");
                return instructions;
            }
        }
        /// <summary>
        /// backing variable for the ice property
        /// </summary>
        private bool ice = true;
        /// <summary>
        /// Checks if the user wants the ice(gives the option)
        /// </summary>
        public bool Ice { get; set; } = true;
        /// <summary>
        /// backing variable for the cream property
        /// </summary>
        private bool roomforcream = true;
        /// <summary>
        /// chekcs if the user wants cream
        /// </summary>
        public bool RoomForCream { get; set; } = true;
        /// <summary>
        /// backing variable for the Decaf property
        /// </summary>
        private bool decaf = true;
        /// <summary>
        /// Checks if user wants decaf
        /// </summary>
        public bool Decaf { get; set; } = true;

    }
}

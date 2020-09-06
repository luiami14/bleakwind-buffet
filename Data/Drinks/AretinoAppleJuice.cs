/*
 * Author: Luis Amiel
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent one of the drinks in the menu
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice
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
        /// Price of the juice
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 0.62;
                }
                else if (size == Size.Medium)
                {
                    return 0.87;
                }
                else if (size == Size.Large)
                {
                    return 1.01;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// Gets the calories of juice
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 44;
                }
                else if (size == Size.Medium)
                {
                    return 88;
                }
                else if (size == Size.Large)
                {
                    return 132;
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
        /// <returns>returns the size and name of the drink</returns>
        public override string ToString()
        {
            return size.ToString() + " Aretino Apple Juice";
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
        public bool Ice { get; set; } = false;
    }
}

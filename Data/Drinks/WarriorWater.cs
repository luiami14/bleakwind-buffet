/*
 * Author: Luis Amiel
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent one of the drinks in the menu
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater
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
        /// Price of the water
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 0.00;
                }
                else if (size == Size.Medium)
                {
                    return 0.00;
                }
                else if (size == Size.Large)
                {
                    return 0.00;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// Gets the calories of water
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 0;
                }
                else if (size == Size.Medium)
                {
                    return 0;
                }
                else if (size == Size.Large)
                {
                    return 0;
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
        /// <returns></returns>
        public override string ToString()
        {
            return size.ToString() + " Warrior Water";
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
        /// backing variable for the lemon property
        /// </summary>
        private bool lemon = true;
        /// <summary>
        /// Checks if the user wants lemon
        /// </summary>
        public bool Lemon { get; set; } = false;
        /// <summary>
        /// This method makes a new List everytime a user is ordering this drink
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");
                return instructions;
            }
        }
    }
}

/*
 * Author: Luis Amiel
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent one of the drinks in the menu
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda
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
        /// Price of the Sailor soda
        /// </summary>
        public double Price
        {
            get
            {
                if(size == Size.Small)
                {
                    return 1.42;
                }
                else if(size== Size.Medium)
                {
                    return 1.74;
                }
                else if(size==Size.Large)
                {
                    return 2.07;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// Gets the calories of sailorSoda
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 117;
                }
                else if (size == Size.Medium)
                {
                    return 153;
                }
                else if (size== Size.Large)
                {
                    return 205;
                }
                else
                {
                    throw new NotImplementedException();
                }
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
                if (!Ice) instructions.Add("Hold ice");
                return instructions;
            }
        }
        /// <summary>
        /// This method just prints out the name of the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size.ToString()+flavor.ToString()+"Sailor Soda";
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
        /// backing variable for the sodaflavor property
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.Cherry;
        /// <summary>
        /// Checks if the user wants the flavor(gives the option)
        /// </summary>
        public SodaFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }
        }
    }
}

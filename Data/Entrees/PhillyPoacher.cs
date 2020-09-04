/*
 * Author: Luis Amiel
 * Class name: Philly Poacher.cs
 * Purpose: Class used to represent one of the entrees in the menu
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher
    {
        /// <summary>
        /// Price of the sandwich
        /// </summary>
        public double Price
        {
            get
            {
                return 7.23;
            }
        }
        /// <summary>
        /// Gets the calories of the sandwich
        /// </summary>
        public int Calories
        {
            get
            {
                return 784;
            }
        }
        /// <summary>
        /// Checks if the user wants Sirloin (gives the option)
        /// </summary>
        public bool Sirloin { get; set; } = true;
        /// <summary>
        /// Checks if the user wants Onion (gives the option)
        /// </summary>
        public bool Onion { get; set; } = true;
        /// <summary>
        /// Checks if the user wants Roll (gives the option)
        /// </summary>
        public bool Roll { get; set; } = true;
        /// <summary>
        /// This method makes a new List everytime a user is odering this sandwich
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onions");
                if (!Roll) instructions.Add("Hold roll");
                return instructions;
            }
        }
        /// <summary>
        /// This method just prints out the name of the sandwich
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}

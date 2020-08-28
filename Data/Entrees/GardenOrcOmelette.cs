/*
 * Author: Luis Amiel
 * Class name: GardenOrcOmelelette.cs
 * Purpose: Class used to represent one of the entrees in the menu
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette
    {
        /// <summary>
        /// Price of the Omelette
        /// </summary>
        public double Price
        {
            get
            {
                return 4.57;
            }
        }
        /// <summary>
        /// Gets the calories of the omellette
        /// </summary>
        public int Calories
        {
            get
            {
                return 404;
            }
        }
        /// <summary>
        /// Checks if the user wants Broccoli (gives the option)
        /// </summary>
        public bool Broccoli { get; set; } = true;
        /// <summary>
        /// Checks if the user wants Mushrooms (gives the option)
        /// </summary>
        public bool Mushrooms { get; set; } = true;
        /// <summary>
        /// Checks if the user wants Tomato (gives the option)
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// Checks if the user wants Cheddar (gives the option)
        /// </summary>
        public bool Cheddar { get; set; } = true;
        /// <summary>
        /// This method makes a new List everytime a user is odering this breakfast.
        /// </summary>
        public List<string> SpecialIntructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }
        }
        /// <summary>
        /// This method just prints out the name of the omelette
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}

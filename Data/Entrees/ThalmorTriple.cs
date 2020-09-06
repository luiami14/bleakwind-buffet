/*
 * Author: Luis Amiel
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent one of the entrees in the menu
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple
    {
        /// <summary>
        /// Price of the burger
        /// </summary>
        public double Price
        {
            get
            {
                return 8.32;
            }
        }
        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public uint Calories
        {
            get
            {
                return 943;
            }
        }
        /// <summary>
        /// a private variable that is set to true initially
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// Checks if the user wants ketchup or not
        /// </summary>
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }
            set
            {
                ketchup = value;
            }
        }
        /// <summary>
        /// Checks if the user wants the bun(gives the option)
        /// </summary>
        public bool Bun { get; set; } = true;
        /// <summary>
        /// Checks if the user wants mustard (gives the option)
        /// </summary>
        public bool Mustard { get; set; } = true;
        /// <summary>
        /// Checks if the user wants Pickles (gives the option)
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        /// Checks if the user wants cheese (gives the option)
        /// </summary>
        public bool Cheese { get; set; } = true;
        /// <summary>
        /// Checks if the user wants tomato (gives the option)
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// Checks if the user wants lettuce (gives the option)
        /// </summary>
        public bool Lettuce { get; set; } = true;
        /// <summary>
        /// Checks if the user wants mayo (gives the option)
        /// </summary>
        public bool Mayo { get; set; } = true;
        /// <summary>
        /// Checks if the user wants bacon (gives the option)
        /// </summary>
        public bool Bacon { get; set; } = true;
        /// <summary>
        /// Checks if the user wants eggs (gives the option)
        /// </summary>
        public bool Egg { get; set; } = true;
        /// <summary>
        /// This method makes a new List everytime a user is odering this burger.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");
                return instructions;
            }
        }
        /// <summary>
        /// This method just prints out the name of the burger
        /// </summary>
        /// <returns>returns the name of the entree</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}

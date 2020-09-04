/*
 * Author: Luis Amiel
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent one of the many entrees
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// All of the ingredients and calories of the burger
    /// </summary>
    public class BriarheartBurger
    {
        /// <summary>
        /// Price of the burger
        /// </summary>
        public double Price
        {
            get
            {
                return 6.32;
            }
        }
        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public int Calories
        {
            get
            {
                return 732;
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
                return instructions;
            }
        }
        /// <summary>
        /// This method just prints out the name of the burger
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}

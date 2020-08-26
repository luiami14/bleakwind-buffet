/*
 * Author: Luis Amiel
 * Class name: Briarheart Burger.cs
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
        /// 
        /// </summary>
        public bool Bun
        {
            get;
            set;
        } = true;

        private bool mustard = true;
        /// <summary>
        /// 
        /// </summary>
        public bool Mustard
        {
            get
            {
                return mustard;
            }
            set
            {
                mustard = value;
            }
        }

        private List<string> specialIntructions = new List<string>();
        public List<string> SpecialIntructions
        {
            get => new List<string>(specialIntructions);
        }
    }
}

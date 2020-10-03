﻿/*
 * Author: Luis Amiel
 * Class name: Philly Poacher.cs
 * Purpose: Class used to represent one of the entrees in the menu
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher : Entree, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Price of the sandwich
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.23;
            }
        }
        /// <summary>
        /// Gets the calories of the sandwich
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 784;
            }
        }
        /// <summary>
        /// a private variable that is set to true initially
        /// </summary>
        private bool sirloin = true;
        /// <summary>
        /// Checks if the user wants Sirloin (gives the option)
        /// </summary>
        public bool Sirloin
        {
            get
            {
                return sirloin;
            }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// a private variable that is set to true initially
        /// </summary>
        private bool onion = true;
        /// <summary>
        /// Checks if the user wants Onion (gives the option)
        /// </summary>
        public bool Onion
        {
            get
            {
                return onion;
            }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// a private variable that is set to true initially
        /// </summary>
        private bool roll = true;
        /// <summary>
        /// Checks if the user wants Roll (gives the option)
        /// </summary>
        public bool Roll
        {
            get
            {
                return roll;
            }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// This method makes a new List everytime a user is odering this sandwich
        /// </summary>
        public override List<string> SpecialInstructions
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
        /// <returns>returns the name of the entree</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}

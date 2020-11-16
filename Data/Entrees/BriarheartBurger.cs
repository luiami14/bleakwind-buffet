/*
 * Author: Luis Amiel
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent one of the many entrees
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// All of the ingredients and calories of the burger
    /// </summary>
    public class BriarheartBurger : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// property called category
        /// </summary>
        public override string Category
        {
            get
            {
                return "Entree";
            }
        }
        /// <summary>
        /// Price of the burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.32;
            }
        }
        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 743;
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
                NotifyPropertyChanged("Ketchup");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }
        /// <summary>
        /// a private variable that is set to true initially
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// Checks if the user wants the bun(gives the option)
        /// </summary>
        public bool Bun
        {
            get
            {
                return bun;
            }
            set
            {
                bun = value;
                NotifyPropertyChanged("Bun");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// a private variable that is set to true initially
        /// </summary>
        private bool mustard = true;
        /// <summary>
        /// Checks if the user wants mustard (gives the option)
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
                NotifyPropertyChanged("Mustard");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }
        /// <summary>
        /// a private variable that is set to true initially
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// Checks if the user wants Pickles (gives the option)
        /// </summary>
        public bool Pickle
        {
            get
            {
                return pickle;
            }
            set
            {
                pickle = value;
                NotifyPropertyChanged("Pickle");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }
        /// <summary>
        /// a private variable that is set to true initially
        /// </summary>
        private bool cheese = true;
        /// <summary>
        /// Checks if the user wants cheese (gives the option)
        /// </summary>
        public bool Cheese
        {
            get
            {
                return cheese;
            }
            set
            {
                cheese = value;
                NotifyPropertyChanged("Cheese");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }
        /// <summary>
        /// This method makes a new List everytime a user is odering this burger.
        /// </summary>
        public override List<string> SpecialInstructions
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
        /// name of the string
        /// </summary>
        public string Name
        {
            get => this.ToString();
        }
        /// <summary>
        /// This method just prints out the name of the burger
        /// </summary>
        /// <returns>returns the name of the entree</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
        /// <summary>
        /// This method is the description online
        /// </summary>
        public override string Description
        {
            get
            {
                return "Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.";
            }
        }
    }
}

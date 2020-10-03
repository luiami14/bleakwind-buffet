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

        public event PropertyChangedEventHandler PropertyChanged;

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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
        /// This method just prints out the name of the burger
        /// </summary>
        /// <returns>returns the name of the entree</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}

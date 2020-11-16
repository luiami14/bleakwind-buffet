/*
 * Author: Luis Amiel
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent one of the entrees in the menu
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple : Entree, INotifyPropertyChanged
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
        /// This method is the description online
        /// </summary>
        public override string Description
        {
            get
            {
                return "Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.";
            }
        }
        /// <summary>
        /// Price of the burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 8.32;
            }
        }
        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public override uint Calories
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
        /// a private variable that is set to true initially
        /// </summary>
        private bool tomato = true;
        /// <summary>
        /// Checks if the user wants tomato (gives the option)
        /// </summary>
        public bool Tomato
        {
            get
            {
                return tomato;
            }
            set
            {
                tomato = value;
                NotifyPropertyChanged("Tomato");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }
        /// <summary>
        /// a private variable that is set to true initially
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// Checks if the user wants lettuce (gives the option)
        /// </summary>
        public bool Lettuce
        {
            get
            {
                return lettuce;
            }
            set
            {
                lettuce = value;
                NotifyPropertyChanged("Lettuce");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }
        /// <summary>
        /// a private variable that is set to true initially
        /// </summary>
        private bool mayo = true;
        /// <summary>
        /// Checks if the user wants mayo (gives the option)
        /// </summary>
        public bool Mayo
        {
            get
            {
                return mayo;
            }
            set
            {
                mayo = value;
                NotifyPropertyChanged("Mayo");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }
        /// <summary>
        /// a private variable that is set to true initially
        /// </summary>
        private bool bacon = true;
        /// <summary>
        /// Checks if the user wants bacon (gives the option)
        /// </summary>
        public bool Bacon
        {
            get
            {
                return bacon;
            }
            set
            {
                bacon = value;
                NotifyPropertyChanged("Bacon");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }
        /// <summary>
        /// a private variable that is set to true initially
        /// </summary>
        private bool egg = true;
        /// <summary>
        /// Checks if the user wants eggs (gives the option)
        /// </summary>
        public bool Egg
        {
            get
            {
                return egg;
            }
            set
            {
                egg = value;
                NotifyPropertyChanged("Egg");
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
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");
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
            return "Thalmor Triple";
        }
    }
}

﻿/*
 * Author: Luis Amiel
 * Class name: GardenOrcOmelelette.cs
 * Purpose: Class used to represent one of the entrees in the menu
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette : Entree, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Price of the Omelette
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.57;
            }
        }
        /// <summary>
        /// Gets the calories of the omellette
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 404;
            }
        }
        /// <summary>
        /// a private variable that is set to true initially
        /// </summary>
        private bool broccoli = true;
        /// <summary>
        /// Checks if the user wants Broccoli (gives the option)
        /// </summary>
        public bool Broccoli
        {
            get
            {
                return broccoli;
            }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// a private variable that is set to true initially
        /// </summary>
        private bool mushrooms = true;
        /// <summary>
        /// Checks if the user wants Mushrooms (gives the option)
        /// </summary>
        public bool Mushrooms
        {
            get
            {
                return mushrooms;
            }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// a private variable that is set to true initially
        /// </summary>
        private bool tomato = true;
        /// <summary>
        /// Checks if the user wants Tomato (gives the option)
        /// </summary>
        public bool Tomato
        {
            get
            {
                return tomato;
            }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// a private variable that is set to true initially
        /// </summary>
        private bool cheddar = true;
        /// <summary>
        /// Checks if the user wants Cheddar (gives the option)
        /// </summary>
        public bool Cheddar
        {
            get
            {
                return cheddar;
            }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// This method makes a new List everytime a user is odering this breakfast.
        /// </summary>
        public override List<string> SpecialInstructions
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
        /// <returns>returns the name of the entree</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}

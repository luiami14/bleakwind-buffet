/*
 * Author: Luis Amiel
 * Class name: Drink.cs
 * Purpose: Class used for a base class
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interface;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing the common properties of drinks
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// a private variable that is set to true initially
        /// </summary>
        private Size s;
        /// <summary>
        /// The size of the drink
        /// </summary>
        public virtual Size Size
        {
            get
            {
                return s;
            }
            set
            {
                s = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }
        /// <summary>
        /// The price of the drink
        /// </summary>
        /// <value>
        /// In Us dollars
        /// </value>
        public abstract double Price { get; }
        /// <summary>
        /// The calories of the drink
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// Special instructions to prepare the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}

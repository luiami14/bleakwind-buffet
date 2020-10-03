/*
 * Author: Luis Amiel
 * Class name: Entree.cs
 * Purpose: Class used for a base class
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interface;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A base class representing the common properties of drinks
    /// </summary>
    public abstract class Entree : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
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

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

        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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
        /// <summary>
        /// This is a property called Description, displays the descriptions
        /// </summary>
        public abstract string Description { get; }
        /// <summary>
        /// name of the string
        /// </summary>
        public virtual string Name
        {
            get => this.ToString();
        }
        /// <summary>
        /// property called category
        /// </summary>
        public abstract string Category { get; }
    }
}

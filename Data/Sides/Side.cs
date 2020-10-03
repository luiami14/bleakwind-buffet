/*
 * Author: Luis Amiel
 * Class name: Side.cs
 * Purpose: Class used for a base class
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interface;

namespace BleakwindBuffet.Data.Sides
{
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private Size size;
        /// <summary>
        /// The size of the drink
        /// </summary>
        public virtual Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
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

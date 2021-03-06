﻿/*
 * Author: Luis Amiel
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent one of the drinks in the menu
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// property called category
        /// </summary>
        public override string Category
        {
            get
            {
                return "Drink";
            }
        }
        /// <summary>
        /// This method is the description online
        /// </summary>
        public override string Description
        {
            get
            {
                return "Fair trade, fresh ground dark roast coffee.";
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
        /// Price of the coffee
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 0.75;
                }
                else if (Size == Size.Medium)
                {
                    return 1.25;
                }
                else //if (Size == Size.Large)
                {
                    return 1.75;
                }
            }
        }
        /// <summary>
        /// Gets the calories of coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 7;
                }
                else if (Size == Size.Medium)
                {
                    return 10;
                }
                else //if (Size == Size.Large)
                {
                    return 20;
                }
            }
        }
        /// <summary>
        /// This method just prints out the name of the drink
        /// </summary>
        /// <returns>returns the name of the drink</returns>
        public override string ToString()
        {
            if(Decaf == true)
            {
                return Size.ToString()+ " Decaf Candlehearth Coffee";
            }
            else
            {
                return Size.ToString() + " Candlehearth Coffee";
            }
        }
        /// <summary>
        /// This method makes a new List everytime a user is odering this drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");
                return instructions;
            }
        }
        /// <summary>
        /// backing variable for the ice property
        /// </summary>
        private bool ice = false;
        /// <summary>
        /// Checks if the user wants the ice(gives the option)
        /// </summary>
        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
                NotifyPropertyChanged("Ice");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }
        /// <summary>
        /// backing variable for the cream property
        /// </summary>
        private bool roomforcream = false;
        /// <summary>
        /// chekcs if the user wants cream
        /// </summary>
        public bool RoomForCream 
        {
            get
            {
                return roomforcream;
            } 
            set
            {
                roomforcream = value;
                NotifyPropertyChanged("RoomForCream");
                NotifyPropertyChanged("SpecialInstructions");
            } 
        } 
        /// <summary>
        /// backing variable for the Decaf property
        /// </summary>
        private bool decaf = true;
        /// <summary>
        /// Checks if user wants decaf
        /// </summary>
        public bool Decaf { get; set; } = false;

    }
}

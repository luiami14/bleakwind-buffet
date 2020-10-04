/*
 * Author: Luis Amiel
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent one of the drinks in the menu
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Price of the juice
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 0.62;
                }
                else if (Size == Size.Medium)
                {
                    return 0.87;
                }
                else if (Size == Size.Large)
                {
                    return 1.01;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// Gets the calories of juice
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 44;
                }
                else if (Size == Size.Medium)
                {
                    return 88;
                }
                else if (Size == Size.Large)
                {
                    return 132;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// This method just prints out the name of the drink
        /// </summary>
        /// <returns>returns the size and name of the drink</returns>
        public override string ToString()
        {
            return Size.ToString() + " Aretino Apple Juice";
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
    }
}

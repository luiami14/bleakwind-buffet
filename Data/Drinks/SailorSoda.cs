/*
 * Author: Luis Amiel
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent one of the drinks in the menu
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda: Drink, INotifyPropertyChanged
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
                return "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.";
            }
        }
        /// <summary>
        /// Price of the Sailor soda
        /// </summary>
        public override double Price
        {
            get
            {
                if(Size == Size.Small)
                {
                    return 1.42;
                }
                else if(Size== Size.Medium)
                {
                    return 1.74;
                }
                else //if(Size==Size.Large)
                {
                    return 2.07;
                }
            }
        }
        /// <summary>
        /// Gets the calories of sailorSoda
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 117;
                }
                else if (Size == Size.Medium)
                {
                    return 153;
                }
                else //if (Size== Size.Large)
                {
                    return 205;
                }
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
                if (!Ice) instructions.Add("Hold ice");
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
        /// This method just prints out the name of the drink
        /// </summary>
        /// <returns>returns the name of the drink</returns>
        public override string ToString()
        {
            return Size.ToString() + " " + flavor.ToString() + " Sailor Soda";
        }
        /// <summary>
        /// backing variable for the ice property
        /// </summary>
        private bool ice = true;
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
        /// backing variable for the sodaflavor property
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.Cherry;
        /// <summary>
        /// Checks if the user wants the flavor(gives the option)
        /// </summary>
        public SodaFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
                NotifyPropertyChanged("Name");
                NotifyPropertyChanged("Flavor");
            }
        }
    }
}

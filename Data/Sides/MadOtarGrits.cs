/*
 * Author: Luis Amiel
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent one of the sides in the menu
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits : Side, INotifyPropertyChanged
    {
        /// <summary>
        /// This method is the description online
        /// </summary>
        public override string Description
        {
            get
            {
                return "Cheesey Grits.";
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
        /// Price of the Grits
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 1.22;
                }
                else if (Size == Size.Medium)
                {
                    return 1.58;
                }
                else //if (Size == Size.Large)
                {
                    return 1.93;
                }
            }
        }
        /// <summary>
        /// Gets the calories of Grits
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 105;
                }
                else if (Size == Size.Medium)
                {
                    return 142;
                }
                else //if (Size == Size.Large)
                {
                    return 179;
                }
            }
        }
        /// <summary>
        /// This method just prints out the name of the Grits
        /// </summary>
        /// <returns>returns the name of the side</returns>
        public override string ToString()
        {
            return Size.ToString() + " Mad Otar Grits";
        }
        /// <summary>
        /// This method makes a new List everytime a user is odering
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }
    }
}

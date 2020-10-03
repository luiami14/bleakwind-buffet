/*
 * Author: Luis Amiel
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent one of the sides in the menu
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad : Side, INotifyPropertyChanged
    {
        /// <summary>
        /// Price of the salad
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 0.93;
                }
                else if (Size == Size.Medium)
                {
                    return 1.28;
                }
                else if (Size == Size.Large)
                {
                    return 1.82;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// Gets the calories of salad
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 41;
                }
                else if (Size == Size.Medium)
                {
                    return 52;
                }
                else if (Size == Size.Large)
                {
                    return 73;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// This method just prints out the name of the salad
        /// </summary>
        /// <returns>returns the name of the side</returns>
        public override string ToString()
        {
            return Size.ToString() + " Vokun Salad";
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

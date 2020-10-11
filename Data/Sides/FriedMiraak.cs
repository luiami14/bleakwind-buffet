/*
 * Author: Luis Amiel
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent one of the sides in the menu
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak : Side, INotifyPropertyChanged
    {
        /// <summary>
        /// Price of the pancakes
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 1.78;
                }
                else if (Size == Size.Medium)
                {
                    return 2.01;
                }
                else //if (Size == Size.Large)
                {
                    return 2.88;
                }
            }
        }
        /// <summary>
        /// Gets the calories of pancakes
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 151;
                }
                else if (Size == Size.Medium)
                {
                    return 236;
                }
                else //if (Size == Size.Large)
                {
                    return 306;
                }
            }
        }
        /// <summary>
        /// This method just prints out the name of the pancake
        /// </summary>
        /// <returns>returns the name of the side</returns>
        public override string ToString()
        {
            return Size.ToString() + " Fried Miraak";
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

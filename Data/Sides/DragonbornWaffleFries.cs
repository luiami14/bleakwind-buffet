/*
 * Author: Luis Amiel
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent one of the sides in the menu
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries
    {
        /// <summary>
        /// private variable that initializes the size
        /// </summary>
        private Size size = Size.Small;
        /// <summary>
        /// Provides available sizes
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
        /// <summary>
        /// Price of the fries
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 0.42;
                }
                else if (size == Size.Medium)
                {
                    return 0.76;
                }
                else if (size == Size.Large)
                {
                    return 0.96;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// Gets the calories of fries
        /// </summary>
        public int Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 77;
                }
                else if (size == Size.Medium)
                {
                    return 89;
                }
                else if (size == Size.Large)
                {
                    return 100;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// This method just prints out the name of the fries
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size.ToString() + "Dragonborn Waffle Fries";
        }
    }
}

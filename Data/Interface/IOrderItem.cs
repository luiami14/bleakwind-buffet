/*
 * Author: Luis Amiel
 * Class name: IOrderItem.cs
 * Purpose: A Interface for Entreee,Drink, and Side
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Interface
{
    public interface IOrderItem
    {
        /// <summary>
        /// The price of the drink
        /// </summary>
        /// <value>
        /// In Us dollars
        /// </value>
        double Price { get; }
        /// <summary>
        /// The calories of the drink
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// Special instructions to prepare the drink
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}

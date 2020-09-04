/*
 * Author: Luis Amiel
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent one of the entrees in the menu
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// Price of the breakfast
        /// </summary>
        public double Price
        {
            get
            {
                return 5.62;
            }
        }
        /// <summary>
        /// Gets the calories of the breakfast
        /// </summary>
        public int Calories
        {
            get
            {
                return 602;
            }
        }
        /// <summary>
        /// Checks if the user wants sausage (gives the option)
        /// </summary>
        public bool SausageLink { get; set; } = true;
        /// <summary>
        /// Checks if the user wants egg (gives the option)
        /// </summary>
        public bool Egg { get; set; } = true;
        /// <summary>
        /// Checks if the user wants hashbrown (gives the option)
        /// </summary>
        public bool HashBrowns { get; set; } = true;
        /// <summary>
        /// Checks if the user wants pancake (gives the option)
        /// </summary>
        public bool Pancake { get; set; } = true;
        /// <summary>
        /// This method makes a new List everytime a user is odering this breakfast.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                return instructions;
            }
        }
        /// <summary>
        /// This method just prints out the name of the breakfast
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}

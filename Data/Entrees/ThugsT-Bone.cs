/*
 * Author: Luis Amiel
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent one of the entrees in the menu
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone
    {
        /// <summary>
        /// Price of the T-Bone
        /// </summary>
        public double Price
        {
            get
            {
                return 6.44;
            }
        }
        /// <summary>
        /// Gets the calories of the T-Bone
        /// </summary>
        public int Calories
        {
            get
            {
                return 982;
            }
        }
        /// <summary>
        /// This method makes a new List everytime a user is odering this T-Bone
        /// </summary>
        public List<string> SpecialIntructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }
        /// <summary>
        /// This method just prints out the name of the T-Bone
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}

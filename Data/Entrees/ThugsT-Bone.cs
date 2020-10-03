/*
 * Author: Luis Amiel
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent one of the entrees in the menu
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone : Entree, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Price of the T-Bone
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.44;
            }
        }
        /// <summary>
        /// Gets the calories of the T-Bone
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 982;
            }
        }
        /// <summary>
        /// This method makes a new List everytime a user is odering this T-Bone
        /// </summary>
        public override List<string> SpecialInstructions
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
        /// <returns>returns the name of the entree</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}

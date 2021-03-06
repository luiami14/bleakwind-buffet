﻿/*
 * Author: Luis Amiel
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent one of the entrees in the menu
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// property called category
        /// </summary>
        public override string Category
        {
            get
            {
                return "Entree";
            }
        }
        /// <summary>
        /// This method is the description online
        /// </summary>
        public override string Description
        {
            get
            {
                return "Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.";
            }
        }
        /// <summary>
        /// Price of the breakfast
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.62;
            }
        }
        /// <summary>
        /// Gets the calories of the breakfast
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 602;
            }
        }
        /// <summary>
        /// a private variable that is set to true initially
        /// </summary>
        private bool sausagelink = true;
        /// <summary>
        /// Checks if the user wants sausage (gives the option)
        /// </summary>
        public bool SausageLink
        {
            get
            {
                return sausagelink;
            }
            set
            {
                sausagelink = value;
                NotifyPropertyChanged("SausageLink");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }
        /// <summary>
        /// a private variable that is set to true initially
        /// </summary>
        private bool egg = true;
        /// <summary>
        /// Checks if the user wants egg (gives the option)
        /// </summary>
        public bool Egg
        {
            get
            {
                return egg;
            }
            set
            {
                egg = value;
                NotifyPropertyChanged("Egg");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }
        /// <summary>
        /// a private variable that is set to true initially
        /// </summary>
        private bool hashbrowns = true;
        /// <summary>
        /// Checks if the user wants hashbrown (gives the option)
        /// </summary>
        public bool HashBrowns
        {
            get
            {
                return hashbrowns;
            }
            set
            {
                hashbrowns = value;
                NotifyPropertyChanged("HashBrowns");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }
        /// <summary>
        /// a private variable that is set to true initially
        /// </summary>
        private bool pancake = true;
        /// <summary>
        /// Checks if the user wants pancake (gives the option)
        /// </summary>
        public bool Pancake
        {
            get
            {
                return pancake;
            }
            set
            {
                pancake = value;
                NotifyPropertyChanged("Pancake");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }
        /// <summary>
        /// This method makes a new List everytime a user is odering this breakfast.
        /// </summary>
        public override List<string> SpecialInstructions
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
        /// name of the string
        /// </summary>
        public string Name
        {
            get => this.ToString();
        }
        /// <summary>
        /// This method just prints out the name of the breakfast
        /// </summary>
        /// <returns>returns the name of the entree</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}

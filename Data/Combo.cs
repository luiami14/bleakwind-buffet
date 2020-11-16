using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interface;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// This class combo is the all the logic for the this project
    /// </summary>
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// 
        /// </summary>
        public string Category
        {
            get
            {
                return "";
            }
        }
        /// <summary>
        /// This is a property called Description, displays the descriptions
        /// </summary>
        public string Description
        {
            get
            {
                return "";
            }
        }
        /// <summary>
        /// Property that gets the price
        /// </summary>
        public double Price
        {
            get
            {
                return ss.Price + bb.Price + sd.Price - 1;
            }
        }
        /// <summary>
        /// Property that gets the calories
        /// </summary>
        public uint Calories
        {
            get
            {
                return ss.Calories + bb.Calories + sd.Calories - 1;
            }
        }
        /// <summary>
        /// property that gets the specialintructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                instructions.Add(bb.ToString());
                instructions.AddRange(bb.SpecialInstructions);
                instructions.Add(ss.ToString());
                instructions.AddRange(ss.SpecialInstructions);
                instructions.Add(sd.ToString());
                instructions.AddRange(sd.SpecialInstructions);
                return instructions;
            }
        }
        /// <summary>
        /// event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /*backing variable */
        Drink ss = new Data.Drinks.SailorSoda();
        /*backing variable */
        Entree bb = new Data.Entrees.BriarheartBurger();
        /*backing variable */
        Side sd = new Data.Sides.DragonbornWaffleFries();
        /// <summary>
        /// Property that gets the drink
        /// </summary>
        public Drink Drink
        {
            get
            {
                return ss;
            }
            set
            {
                ss.PropertyChanged -= ItemChangedListener;
                ss = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                ss.PropertyChanged += ItemChangedListener;
            }
        }
        /// <summary>
        /// property that gets the side
        /// </summary>
        public Side Side
        {
            get
            {
                return sd;
            }
            set
            {
                sd.PropertyChanged -= ItemChangedListener;
                sd = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                sd.PropertyChanged += ItemChangedListener;
            }
        }
        /// <summary>
        /// Property that gets the entree
        /// </summary>
        public Entree Entree
        {
            get
            {
                return bb;
            }
            set
            {
                bb.PropertyChanged -= ItemChangedListener;
                bb = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                bb.PropertyChanged += ItemChangedListener;
            }
        }
        /// <summary>
        /// listener that changes when the user changes size, flavor,and special instructions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Size")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
            else if(e.PropertyName == "Flavor")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
            else if(e.PropertyName == "SpecialInstructions")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
            else
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// The constructor
        /// </summary>
        public Combo()
        {
            ss.PropertyChanged += ItemChangedListener;
            bb.PropertyChanged += ItemChangedListener;
            sd.PropertyChanged += ItemChangedListener;
        }
        /// <summary>
        /// name of the string
        /// </summary>
        public virtual string Name
        {
            get => this.ToString();
        }
    }
}

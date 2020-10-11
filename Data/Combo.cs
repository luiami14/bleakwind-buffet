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
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// 
        /// </summary>
        public double Price
        {
            get
            {
                return ss.Price + bb.Price + sd.Price - 1;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public uint Calories
        {
            get
            {
                return ss.Calories + bb.Calories + sd.Calories - 1;
            }
        }
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        Drink ss = new Data.Drinks.SailorSoda();
        Entree bb = new Data.Entrees.BriarheartBurger();
        Side sd = new Data.Sides.DragonbornWaffleFries();
        /// <summary>
        /// 
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                ss.PropertyChanged += ItemChangedListener;
            }
        }
        /// <summary>
        /// 
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                sd.PropertyChanged += ItemChangedListener;
            }
        }
        /// <summary>
        /// 
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                bb.PropertyChanged += ItemChangedListener;
            }
        }
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        public Combo()
        {
            ss.PropertyChanged += ItemChangedListener;
            bb.PropertyChanged += ItemChangedListener;
            sd.PropertyChanged += ItemChangedListener;
        }
    }
}

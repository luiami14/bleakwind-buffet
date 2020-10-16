using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Interface;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// This class order is the all the logic for the this project
    /// </summary>
    public class Order: ObservableCollection<IOrderItem>
    {
        /*backing variable */
        private double salesTaxRate = 0.12;
        /// <summary>
        /// Property that checks the salesTaxRate
        /// </summary>
        public double SalesTaxRate
        {
            get
            {
                return salesTaxRate;
            }
            set
            {
                salesTaxRate = value;
                OnPropertyChanged(new PropertyChangedEventArgs("SalesTaxRate"));
                OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            }
        }
        /// <summary>
        /// Property that gets the subtotal
        /// </summary>
        public double Subtotal
        {
            get
            {
                double subTotal = 0;
                foreach(IOrderItem element in this)
                {
                    subTotal += element.Price;
                }
                return Math.Round(subTotal, 2);
            }
        }
        /// <summary>
        /// Property that gets the Tax
        /// </summary>
        public double Tax
        {
            get => Math.Round(Subtotal * salesTaxRate, 2);
        }
        /// <summary>
        /// Property that gets the total
        /// </summary>
        public double Total
        {
            get => Math.Round(Tax + Subtotal, 2);
        }
        /*backing variable */
        private static double nextOrderNumber = 1;
        /*backing variable */
        private double number;
        /// <summary>
        /// Property that checks number
        /// </summary>
        public double Number
        {
            get
            {
                return number;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public uint Calories
        {
            get
            {
                uint calories =0;
                foreach (IOrderItem element in this)
                {
                    calories += element.Calories;
                }
                return calories;
            }
        }
        /// <summary>
        /// Contructor that checks and implements the listeners
        /// </summary>
        public Order()
        {
            number = nextOrderNumber;
            nextOrderNumber++;
            CollectionChanged += CollectionChangedListener;
        }
        /// <summary>
        /// This collection checks the ones that can change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            OnPropertyChanged(new PropertyChangedEventArgs("Tax"));

            switch(e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach(IOrderItem item in e.NewItems)
                    {
                        if(item is AretinoAppleJuice aj) { aj.PropertyChanged += ItemCollectionChangedListener; }
                        else if(item is CandlehearthCoffee cc) { cc.PropertyChanged += ItemCollectionChangedListener; }
                        else if(item is MarkarthMilk mm) { mm.PropertyChanged += ItemCollectionChangedListener; }
                        else if(item is SailorSoda ss) { ss.PropertyChanged += ItemCollectionChangedListener; }
                        else if(item is WarriorWater ww) { ww.PropertyChanged += ItemCollectionChangedListener; }
                        else if(item is DragonbornWaffleFries dj) { dj.PropertyChanged += ItemCollectionChangedListener; }
                        else if(item is FriedMiraak fm) { fm.PropertyChanged += ItemCollectionChangedListener; }
                        else if(item is MadOtarGrits mg) { mg.PropertyChanged += ItemCollectionChangedListener; }
                        else if(item is VokunSalad vs) { vs.PropertyChanged += ItemCollectionChangedListener; }
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach(IOrderItem item in e.OldItems)
                    {
                        if (item is AretinoAppleJuice aj) { aj.PropertyChanged -= ItemCollectionChangedListener; }
                        else if (item is CandlehearthCoffee cc) { cc.PropertyChanged -= ItemCollectionChangedListener; }
                        else if (item is MarkarthMilk mm) { mm.PropertyChanged -= ItemCollectionChangedListener; }
                        else if (item is SailorSoda ss) { ss.PropertyChanged -= ItemCollectionChangedListener; }
                        else if (item is WarriorWater ww) { ww.PropertyChanged -= ItemCollectionChangedListener; }
                        else if (item is DragonbornWaffleFries dj) { dj.PropertyChanged -= ItemCollectionChangedListener; }
                        else if (item is FriedMiraak fm) { fm.PropertyChanged -= ItemCollectionChangedListener; }
                        else if (item is MadOtarGrits mg) { mg.PropertyChanged -= ItemCollectionChangedListener; }
                        else if (item is VokunSalad vs) { vs.PropertyChanged -= ItemCollectionChangedListener; }
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException("NotifyCollectionChangedAction.Reset not supported");
            }
        }
        /// <summary>
        /// Colection that checks the changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ItemCollectionChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Size")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            }
        }

    }
}

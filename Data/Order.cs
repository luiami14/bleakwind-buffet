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
    public class Order: ObservableCollection<IOrderItem>
    {
        private double salesTaxRate = 0.12;
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
        public double Subtotal
        {
            get
            {
                double subTotal = 0;
                foreach(IOrderItem element in this)
                {
                    subTotal += element.Price;
                }
                return subTotal;
            }
        }
        public double Tax
        {
            get => Subtotal * salesTaxRate;
        }
 
        public double Total
        {
            get => Tax + Subtotal;
        }
        private static double nextOrderNumber = 1;
        private double number;
        public double Number
        {
            get
            {
                return number;
            }
        }
        private uint calories;
        public uint Calories
        {
            get
            {
                return calories;
            }
        }
        public Order()
        {
            number = nextOrderNumber;
            nextOrderNumber++;
        }
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

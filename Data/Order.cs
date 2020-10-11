using BleakwindBuffet.Data.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        void CollectionChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Size")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Price"));
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
            }
            else if(e.PropertyName == "Subtotal")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Price"));
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
            }
            else if (e.PropertyName == "Tax")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Price"));
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
            }
            else if(e.PropertyName == "")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Price"));
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));
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

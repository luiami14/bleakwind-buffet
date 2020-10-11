using BleakwindBuffet.Data.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            }
        }
        private double subTotal;
        public double Subtotal
        {
            get
            {
                return subTotal;
            }
        }
        private double tax;
        public double Tax
        {
            get
            {
                return tax;
            }
        }
        private double total;
        public double Total
        {
            get
            {
                return total;
            }
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
        public Order()
        {
            number = nextOrderNumber;
            nextOrderNumber++;
        }

    }
}

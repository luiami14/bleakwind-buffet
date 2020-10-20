/*
 * Author: Luis Amiel
 * Class name: CashModelView.cs
 * Purpose: Class used to represent the payment options logic of the cash
 */
using System;
using System.Collections.Generic;
using System.Text;
using RoundRegister;

namespace PointOfSale
{
    public class CashModelView
    {
        /// <summary>
        /// This shows if the card was approved or not
        /// </summary>
        /// <param name="amt"></param>
        /// <returns></returns>
        public CardTransactionResult RunCard(double amt)
        {
            return CardReader.RunCard(amt);
        }
        /// <summary>
        /// This method displays the line that seperates the orders
        /// </summary>
        /// <param name="line"></param>
        public void PrintLine(string line)
        {
            RecieptPrinter.PrintLine(line);
        }
        /// <summary>
        /// method that cuts the order when needed
        /// </summary>
        public void CutTape()
        {
            RecieptPrinter.CutTape();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using RoundRegister;

namespace PointOfSale
{
    public class RegisterModelView
    {
        public CardTransactionResult RunCard(double amt)
        {
            return CardReader.RunCard(amt);
        }

        public void PrintLine(string line)
        {
            RecieptPrinter.PrintLine(line);
        }

        public void CutTape()
        {
            RecieptPrinter.CutTape();
        }

    }
}

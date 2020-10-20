using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale
{
    public class RegisterModelView
    {
        public CardTrandasctionResult RunCard(double amt)
        {
            return CardReader.RunCard(amt);
        }
    }
}

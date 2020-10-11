using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests
{
    public class OrderTests
    {
        [Fact]
        public void ChangingSalesTaxRateNotifiesSalesTaxRateProperty()
        {
            Combo d = new Combo();
            Assert.PropertyChanged(d, "SalesTaxRate", () => d.Entree = new BriarheartBurger());
        }
        [Fact]
        public void ChangingSalesTaxRateNotifiesSubtotalProperty()
        {
            Combo d = new Combo();
            Assert.PropertyChanged(d, "Subtotal", () => d.Entree = new BriarheartBurger());
        }
        [Fact]
        public void ChangingSalesTaxRateNotifiesTotalProperty()
        {
            Combo d = new Combo();
            Assert.PropertyChanged(d, "Total", () => d.Entree = new BriarheartBurger());
        }
        [Fact]
        public void ChangingSalesTaxRateNotifiesTaxProperty()
        {
            Combo d = new Combo();
            Assert.PropertyChanged(d, "Tax", () => d.Entree = new BriarheartBurger());
        }
    }
}

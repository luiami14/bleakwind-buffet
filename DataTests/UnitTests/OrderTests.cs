using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.Collections;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests
{
    public class OrderTests
    {
        [Fact]
        public void ImplementsObservableCollection()
        {
            Order c = new Order();
            Assert.IsAssignableFrom<ObservableCollection<IOrderItem>>(c);
        }
        [Fact]
        public void ImplementsINotifyPropertyChange()
        {
            Order c = new Order();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(c);
        }
        [Fact]
        public void ImplementsINotifyColletionChange()
        {
            Order c = new Order();
            Assert.IsAssignableFrom<INotifyCollectionChanged>(c);
        }
        [Fact]
        public void ImplementsICollection()
        {
            Order c = new Order();
            Assert.IsAssignableFrom<ICollection<IOrderItem>>(c);
        }
        [Fact]
        public void ChangingSalesTaxRateNotifiesSalesTaxRateProperty()
        {
            Order d = new Order();
            Assert.PropertyChanged(d, "SalesTaxRate", () => d.SalesTaxRate = 1.12);
        }
        [Fact]
        public void ChangingSalesTaxRateNotifiesSubtotalProperty()
        {
            Order d = new Order();
            Assert.PropertyChanged(d, "Subtotal", () => d.SalesTaxRate = 1.12);
        }
        [Fact]
        public void ChangingSalesTaxRateNotifiesTotalProperty()
        {
            Order d = new Order();
            Assert.PropertyChanged(d, "Total", () => d.SalesTaxRate = 1.12);
        }
        [Fact]
        public void ChangingSalesTaxRateNotifiesTaxProperty()
        {
            Order d = new Order();
            Assert.PropertyChanged(d, "Tax", () => d.SalesTaxRate = 1.12);
        }
        [Fact]
        public void ShouldBeSalesTaxRateDefault()
        {
            Order d = new Order();
            Assert.Equal(0.12, d.SalesTaxRate);
        }
        [Fact]
        public void ShouldBeSubtotalDefault()
        {
            Order d = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            d.Add(bb);
            VokunSalad vs = new VokunSalad();
            d.Add(vs);
            AretinoAppleJuice aj = new AretinoAppleJuice();
            d.Add(aj);
            double total = 0;
            total = bb.Price + aj.Price + vs.Price;
            Assert.Equal(total, d.Subtotal);
        }
        [Fact]
        public void ShouldBeTaxDefault()
        {
            Order d = new Order();
            Assert.Equal(0, d.Tax);
        }
        [Fact]
        public void ShouldBeTotalDefault()
        {
            Order d = new Order();
            Assert.Equal(0, d.Total);
        }
        [Fact]
        public void ShouldBeNumberDefault()
        {
            Order d = new Order();
            Order dd = new Order();
            Assert.Equal((d.Number+1), dd.Number);
        }
        [Fact]
        public void ShouldBeCaloriesDefault()
        {
            Order d = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            d.Add(bb);
            VokunSalad vs = new VokunSalad();
            d.Add(vs);
            AretinoAppleJuice aj = new AretinoAppleJuice();
            d.Add(aj);
            double total = 0;
            total = bb.Calories + aj.Calories + vs.Calories;
            Assert.Equal(total, d.Calories);
        }
    }
}

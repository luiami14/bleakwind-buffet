using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests
{
    public class ComboTests
    {
        [Fact]
        public void ImplementsINotifyPropertyChange()
        {
            Combo c = new Combo();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(c);
        }
        [Fact]
        public void ImplementsIOrderItem()
        {
            Combo c = new Combo();
            Assert.PropertyChanged
        }
    }
}

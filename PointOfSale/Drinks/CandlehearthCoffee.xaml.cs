using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CandleheartCoffee.xaml
    /// </summary>
    public partial class CandlehearthCoffee : UserControl
    {
        Container cn;
        public CandlehearthCoffee(Container c)
        {
            InitializeComponent();
            cn = c;
        }
        void DoneWithOrder(object sender, RoutedEventArgs e)
        {
            cn.MenuSelectionComponent.Child = new View1(cn);
        }
    }
}

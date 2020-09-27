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
    /// Interaction logic for View1.xaml
    /// </summary>
    public partial class View1 : UserControl
    {
        Container cn;

        public View1(Container c)
        {
            InitializeComponent();
            cn = c;
        }

        void ClicksButton(object sender, RoutedEventArgs e)
        {
            Button bt = (Button) sender;
            if (bt.Name == "BriarheartBurger") cn.MenuSelectionComponent.Child = new BriarheartBurger(cn);
            else if() 
        }

    }
}

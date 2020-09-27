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
    /// Interaction logic for View2.xaml
    /// </summary>
    public partial class View2 : UserControl
    {
        Container cn;

        public View2(Container c)
        {
            InitializeComponent();
            cn = c;
        }
    }
}

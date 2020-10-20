using BleakwindBuffet.Data;
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

namespace PointOfSale.EntreesCombo
{
    /// <summary>
    /// Interaction logic for ThugsTBoneCombo.xaml
    /// </summary>
    public partial class ThugsTBoneCombo : UserControl
    {
        /* private back end variable*/
        private Container cn;
        /* private back end variable*/
        private Combo combo;
        /// <summary>
        /// property called container
        /// </summary>
        public Container Container
        {
            get
            {
                return cn;
            }
            set
            {
                cn = value;
            }
        }
        /// <summary>
        /// property called combo
        /// </summary>
        public Combo Combo
        {
            get
            {
                return combo;
            }
            set
            {
                combo = value;
                DataContext = (BleakwindBuffet.Data.Entrees.ThugsTBone)combo.Entree;
            }
        }
        /// <summary>
        /// Displaying the TBone in the container
        /// </summary>
        /// <param name="c">displaying the TBone in the container</param>
        public ThugsTBoneCombo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is when the user is done with their special intructions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneWithOrder(object sender, RoutedEventArgs e)
        {
            cn.MenuSelectionComponent.Child = new ComboCutomizationScreen() { Container = cn };
        }
        /// <summary>
        /// This is when the user wants to cancel the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CancelButton(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                cn.DataContext = new Order();
                cn.MenuSelectionComponent.Child = new View1() { Container = cn };
            }
        }
    }
}

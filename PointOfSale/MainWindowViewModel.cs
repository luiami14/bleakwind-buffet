using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    /// <summary>
    /// 
    /// </summary>
    public class MainWindowViewModel
    {
        public int SwitchView
        {
            get;
            set;
        }
        /// <summary>
        /// 
        /// </summary>
        public MainWindowViewModel()
        {
            SwitchView = 1;
        }
    }
}

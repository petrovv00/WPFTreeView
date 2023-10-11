using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTreeView.Direct.ViewModels.Base
{
    /// <summary>
    /// A base view model that fires Property changed events as needed
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// The event that is fired when any child property changes its value
        /// </summary>

        public event PropertyChangedEventHandler? PropertyChanged = (sender, e) => { };
    }
}

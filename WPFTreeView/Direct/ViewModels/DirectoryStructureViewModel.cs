using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTreeView.Direct.Data;
using WPFTreeView.Direct.ViewModels.Base;

namespace WPFTreeView.Direct.ViewModels
{
    /// <summary>
    /// The view model for the application's main Directory view
    /// </summary>
    public class DirectoryStructureViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// A list of all directories on the machine
        /// </summary>
        public ObservableCollection<DirectoryItemViewModel> Items { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public DirectoryStructureViewModel() 
        {
            // Get logical drives
            var children = DirectoryStructure.GetLogicalDrives();

            // Create the view models from the data
            this.Items = new ObservableCollection<DirectoryItemViewModel>(
                children.Select(drive => new DirectoryItemViewModel(drive.FullPath, DirectoryItemType.Drive)));    
        }

        #endregion

    }
}

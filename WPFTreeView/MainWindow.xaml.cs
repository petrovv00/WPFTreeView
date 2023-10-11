using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using WPFTreeView.Direct.ViewModels;

namespace WPFTreeView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Constructor
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new DirectoryStructureViewModel();
        }

        #endregion
    }
}

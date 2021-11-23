using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace WPF_TreeView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new DirectoryStructureVM();
        }

        #endregion
    }
}

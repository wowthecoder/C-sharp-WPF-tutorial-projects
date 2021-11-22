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
        }

        #endregion

        #region On Loaded

        /// <summary>
        /// When the application first opens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Get every logical drive on the machine
            foreach (var drive in Directory.GetLogicalDrives()) 
            {
                //Create a new item for it
                var item = new TreeViewItem()
                {
                    //Set the header
                    Header = drive,
                    //And the full path
                    Tag = drive
                };

                 item.Items.Add(null);

                //Listen out for items being expanded
                item.Expanded += Folder_Expanded;

                //Add it to the main tree-view
                FolderView.Items.Add(item);
            }
        }

        #endregion

        #region Folder Expanded

        private void Folder_Expanded(object sender, RoutedEventArgs e)
        {
            #region Initial Checks

            var item = (TreeViewItem)sender;

            //Check if the item only contains the dummy data before continuing, if the item has other stuff in it then return
            //When a subfolder is expanded, all the parent folders will call this function too, so we don't want the parent folder to wipe everything again
            //This check is to prevent the parent folder from performing the rest of the function
            if (item.Items.Count != 1 || item.Items[0] != null)
                return;

            //Clear the dummy item
            item.Items.Clear();

            #endregion

            #region Get Folder

            //Get folder name
            string fullPath = (string)item.Tag;

            List<string> directories = new List<string>();

            //Try and get the directories in the folder
            //Ignore any errors while doing so
            try
            {
                string[] dirs = Directory.GetDirectories(fullPath);

                if (dirs.Length > 0)
                    directories.AddRange(dirs);
            }
            catch { }

            //For each directory...
            directories.ForEach(directoryPath =>
            {
                //Create directory item
                var subItem = new TreeViewItem()
                {
                    //Get the name of the folder/file
                    Header = new DirectoryInfo(directoryPath).Name,
                    //Get the full path
                    Tag = directoryPath
                };

                //Add dummy item to show the expand button
                subItem.Items.Add(null);

                subItem.Expanded += Folder_Expanded;

                //Add this folder to the parent
                item.Items.Add(subItem);
            });

            #endregion

            #region Get Files

            List<string> files = new List<string>();

            try
            {
                string[] fs = Directory.GetFiles(fullPath);

                if (fs.Length > 0)
                    files.AddRange(fs);
            }
            catch { }

            files.ForEach(filePath => 
            {
                var subItem = new TreeViewItem()
                {
                    Header = Path.GetFileName(filePath),
                    Tag = filePath
                };

                item.Items.Add(subItem);
            });

            #endregion
        }

        #endregion


    }
}

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Input;

namespace WPF_TreeView
{
    public class DirectoryItemVM : BaseViewModel
    {
        public DirectoryItemType Type { get; set; }
        public string FullPath { get; set; }
        public string Name { get { return this.Type == DirectoryItemType.Drive ? FullPath : DirectoryStructure.GetFileFolderName(FullPath); } }
        public ObservableCollection<DirectoryItemVM> Children { get; set;}
        public bool CanExpand { get { return this.Type != DirectoryItemType.File; } }
        //Indicates if the current item is expanded or not
        public bool IsExpanded
        {
            get 
            {
                return this.Children?.Count(f => f != null) > 0;
            }
            set
            {
                //If the UI tells us to expand...
                if (value == true)
                    Expand();
                else
                    this.ClearChildren();
            }
        }

        //The command to expand the items
        public ICommand ExpandCommand { get; set; }

        public DirectoryItemVM(string FullPath, DirectoryItemType Type)
        {
            this.ExpandCommand = new RelayCommand(Expand);
            this.FullPath = FullPath;
            this.Type = Type;
            this.ClearChildren();
        }

        /// <summary>
        /// Expand the directory and find all children
        /// </summary>
        private void Expand()
        {
            if (this.Type == DirectoryItemType.File)
                return;

            var children = DirectoryStructure.GetDirectoryContents(this.FullPath);
            this.Children = new ObservableCollection<DirectoryItemVM> (children.Select(content => new DirectoryItemVM(content.FullPath, content.Type)));
        }

        /// <summary>
        /// Removes all children from the list, adding a dummy item to show the expand icon if required
        /// </summary>
        private void ClearChildren()
        {
            Children = new ObservableCollection<DirectoryItemVM>();

            //Show the expand icon if this item is not a file
            if (this.Type != DirectoryItemType.File)
                this.Children.Add(null);
        }
    }
}

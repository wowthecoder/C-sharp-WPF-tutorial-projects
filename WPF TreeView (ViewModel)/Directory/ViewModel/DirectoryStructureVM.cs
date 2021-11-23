using System.Collections.ObjectModel;
using System.Linq;

namespace WPF_TreeView
{
    //The view model for the main application directory view
    public class DirectoryStructureVM : BaseViewModel
    {
        //A list of all directories on a machine
        public ObservableCollection<DirectoryItemVM> Items { get; set; }

        public DirectoryStructureVM()
        {
            var children = DirectoryStructure.GetLogicalDrives();
            this.Items = new ObservableCollection<DirectoryItemVM>(children.Select(drive => new DirectoryItemVM(drive.FullPath, drive.Type)));
        }
    }
}

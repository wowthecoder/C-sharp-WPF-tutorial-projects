namespace WPF_TreeView
{
    /// <summary>
    /// Information about a directory item such as a drive, folder or file
    /// </summary>
    public class DirectoryItem
    {
        public DirectoryItemType Type { get; set; }
        public string FullPath { get; set; }
        public string Name { get { return this.Type == DirectoryItemType.Drive ? FullPath : DirectoryStructure.GetFileFolderName(FullPath); } }
    }
}

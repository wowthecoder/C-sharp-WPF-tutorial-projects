using PropertyChanged;
using System.ComponentModel;
using System.Threading.Tasks;

namespace WPF_TreeView
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

using System.Collections.ObjectModel;
using Project3.Models;

namespace Project3.ViewModels;

public class ImpactViewModel : ViewModelBase
{
    private ObservableCollection<Impact> _impacts;

    public ObservableCollection<Impact> Impacts
    {
        get => _impacts;
        set => SetField(ref _impacts, value);
    }

    public ImpactViewModel()
    {
        Impacts = new ObservableCollection<Impact>();
        Impacts.Add(new Impact(1,1,"asdas"));
    }
}
using System.Collections.ObjectModel;
using Project3.Models;

namespace Project3.ViewModels;

public class StrategyViewModel : ViewModelBase
{
    private ObservableCollection<Strategy> _strategies;

    public ObservableCollection<Strategy> Strategies
    {
        get => _strategies;
        set => SetField(ref _strategies, value);
    }

    public StrategyViewModel()
    {
        Strategies = new ObservableCollection<Strategy>();
        Strategies.Add(new Strategy(1,"aaa", "asd"));
    }
}
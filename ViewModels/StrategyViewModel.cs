using System.Collections.ObjectModel;
using System.Linq;
using Avalonia.Collections;
using Project3.Models;

namespace Project3.ViewModels;

public class StrategyViewModel : ViewModelBase
{
    private AvaloniaList<Strategy> _strategies;

    public AvaloniaList<Strategy> Strategies
    {
        get => _strategies;
        set => SetField(ref _strategies, value);
    }

    public StrategyViewModel()
    {
        Strategies = new AvaloniaList<Strategy>();
        LoadStrategies();
    }

    private void LoadStrategies()
    {
        using (var dbContext = new YourDbContext())
        {
            var strategies = dbContext.Strategy.ToList();
            foreach (var strategy in strategies)
            {
                Strategies.Add(strategy);
            }
        }
    }
}
using System.Linq;
using Avalonia.Collections;
using Project3.Models;

namespace Project3.ViewModels;

public class ThreatPreventionViewModel : ViewModelBase
{
    private AvaloniaList<ThreatPrevention> _threatPreventions;

    public AvaloniaList<ThreatPrevention> ThreatPreventions
    {
        get => _threatPreventions;
        set => SetField(ref _threatPreventions, value);
    }

    public ThreatPreventionViewModel()
    {
        ThreatPreventions = new AvaloniaList<ThreatPrevention>();
        LoadThreatPreventions();
    }

    private void LoadThreatPreventions()
    {
        using (var dbContext = new YourDbContext())
        {
            var threatPreventions = dbContext.ThreatPrevention.ToList();
            foreach (var threatPrevention in threatPreventions)
            {
                ThreatPreventions.Add(threatPrevention);
            }
        }
    }
}
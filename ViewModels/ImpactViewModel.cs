using System.Collections.ObjectModel;
using System.Linq;
using Avalonia.Collections;
using Microsoft.EntityFrameworkCore;
using Project3.Models;

namespace Project3.ViewModels;

public class ImpactViewModel : ViewModelBase
{
    private AvaloniaList<Impact> _impacts;

    public AvaloniaList<Impact> Impacts
    {
        get => _impacts;
        set => SetField(ref _impacts, value);
    }

    public ImpactViewModel()
    {
        Impacts = new AvaloniaList<Impact>();
        LoadImpacts();
    }

    private void LoadImpacts()
    {
        using (var dbContext = new YourDbContext())
        {
            var impacts = dbContext.Impact.ToList();
            Impacts = new(impacts);
        }
    }
}
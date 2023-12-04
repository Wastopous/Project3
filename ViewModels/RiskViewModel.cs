using System;
using System.Linq;
using Avalonia.Collections;
using Microsoft.EntityFrameworkCore;
using Project3.Models;

namespace Project3.ViewModels;

public class RiskViewModel : ViewModelBase
{
    private AvaloniaList<Risk> _risks;

    public AvaloniaList<Risk> Risks
    {
        get => _risks;
        set => SetField(ref _risks, value);
    }

    private string _search = "";
    public string Search
    {
        get => _search;
        set
        {
            SetField(ref _search, value);
            OnSearch();
        }
    }

    private void OnSearch()
    {
        using (var dbContext = new YourDbContext())
        {
            var search = Search.ToLower();
            var risks = dbContext.Risk
                .Include(i => i.Impact)
                .Include(c => c.Company)
                .Include(s => s.Strategy)
                .Include(rc => rc.RiskCategory)
                .Include(rm => rm.RiskMitigation)
                .Include(t => t.ThreatPrevention)
                .Where(
                    it => it.RiskID.ToString().Contains(search) ||
                          it.RiskDescription.ToLower().Contains(search) ||
                          it.Company.CompanyName.ToLower()
                              .Contains(search) ||
                          it.Impact.ImpactAmount.ToString()
                              .Contains(search) ||
                          it.Strategy.StrategyName.ToLower()
                              .Contains(search) ||
                          it.RiskMitigation.RiskMitigationName.ToString()
                              .Contains(search) ||
                          it.RiskCategory.RiskCategoryName.ToLower()
                              .Contains(search) ||
                          it.ThreatPrevention.ThreatPreventionName.ToLower()
                              .Contains(search)
                )
                .ToList();
            Risks = new AvaloniaList<Risk>(risks);
        }
    }


    public RiskViewModel()
    {
        Risks = new AvaloniaList<Risk>();
        LoadRisks();
    }
    
    private void LoadRisks()
    {
        using (var dbContext = new YourDbContext()) 
        {
            var risks = dbContext.Risk
                .Include(i => i.Impact)
                .Include(c => c.Company)
                .Include(s =>s.Strategy)
                .Include(rc => rc.RiskCategory)
                .Include(rm => rm.RiskMitigation)
                .Include(t=> t.ThreatPrevention)
               .ToList();
            Risks = new AvaloniaList<Risk>(risks);
        }
    }
}

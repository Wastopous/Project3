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
            foreach (var risk in risks)
            {
                Risks.Add(risk);
            }
        }
    }
}
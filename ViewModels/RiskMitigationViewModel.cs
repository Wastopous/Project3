using System.Linq;
using Avalonia.Collections;
using Project3.Models;
using SkiaSharp;

namespace Project3.ViewModels;

public class RiskMitigationViewModel : ViewModelBase
{
    private AvaloniaList<RiskMitigation> _riskMitigations;

    public AvaloniaList<RiskMitigation> RiskMitigations
    {
        get => _riskMitigations;
        set => SetField(ref _riskMitigations, value);
    }

    public RiskMitigationViewModel()
    {
        RiskMitigations = new AvaloniaList<RiskMitigation>();
        LoadRiskMitigations();
    }

    private void LoadRiskMitigations()
    {
        using (var dbContex = new YourDbContext())
        {
            var riskMitigations = dbContex.RiskMitigation.ToList();
            RiskMitigations = new AvaloniaList<RiskMitigation>(riskMitigations);
        }
    }
}
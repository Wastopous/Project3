using System.Collections.ObjectModel;
using System.Linq;
using Avalonia.Collections;
using Project3.Models;

namespace Project3.ViewModels;

public class RiskCategoryViewModel : ViewModelBase
{
    private AvaloniaList<RiskCategory> _riskCategories;

    public AvaloniaList<RiskCategory> RiskCategories
    {
        get => _riskCategories;
        set => SetField(ref _riskCategories, value);
    }

    public RiskCategoryViewModel()
    {
        RiskCategories = new AvaloniaList<RiskCategory>();
        LoadRiskCategories();
    }

    private void LoadRiskCategories()
    {
        using (var dbContext = new YourDbContext())
        {
            var riskCategories = dbContext.RiskCategory.ToList();
            RiskCategories = new(riskCategories);
        }
    }
}
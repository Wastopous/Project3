using System.Collections.ObjectModel;
using Project3.Models;

namespace Project3.ViewModels;

public class RiskCategoryViewModel : ViewModelBase
{
    private ObservableCollection<RiskCategory> _riskCategories;

    public ObservableCollection<RiskCategory> RiskCategories
    {
        get => _riskCategories;
        set => SetField(ref _riskCategories, value);
    }

    public RiskCategoryViewModel()
    {
        RiskCategories = new ObservableCollection<RiskCategory>();
    }
}
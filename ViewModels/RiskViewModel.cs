using System.Collections.ObjectModel;
using Project3.Models;

namespace Project3.ViewModels;

public class RiskViewModel : ViewModelBase
{
    private ObservableCollection<Risk> _risks;

    public ObservableCollection<Risk> Risks
    {
        get => _risks;
        set => SetField(ref _risks, value);
    }

    public RiskViewModel()
    {
        Risks = new ObservableCollection<Risk>();
        Risks.Add(new Risk(1,"asd"));
    }
}
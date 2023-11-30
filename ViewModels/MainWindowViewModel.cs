namespace Project3.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public RiskViewModel RiskViewModel { get; set; } = new RiskViewModel();
    public CompanyViewModel CompanyViewModel { get; set; } = new CompanyViewModel();
    public StrategyViewModel StrategyViewModel { get; set; } = new StrategyViewModel();
    public RiskCategoryViewModel RiskCategoryViewModel { get; set; } = new RiskCategoryViewModel();
    public ImpactViewModel ImpactViewModel { get; set; } = new ImpactViewModel();
    public RiskMitigationViewModel RiskMitigationViewModel { get; set; } = new RiskMitigationViewModel();
    public ThreatPreventionViewModel ThreatPreventionViewModel { get; set; } = new ThreatPreventionViewModel();
}
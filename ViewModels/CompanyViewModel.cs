using System.Collections.ObjectModel;
using Project3.Models;

namespace Project3.ViewModels;

public class CompanyViewModel : ViewModelBase
{
    private ObservableCollection<Company> _companies;

    public ObservableCollection<Company> Companies
    {
        get => _companies;
        set => SetField(ref _companies, value);
    }

    public CompanyViewModel()
    {
        Companies = new ObservableCollection<Company>();
        Companies.Add(new Company(1, "aaa","adasd"));
    }
}
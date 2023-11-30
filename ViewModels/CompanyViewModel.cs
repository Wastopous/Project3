using System.Collections.ObjectModel;
using System.Linq;
using Avalonia.Collections;
using Project3.Models;

namespace Project3.ViewModels;

public class CompanyViewModel : ViewModelBase
{
    private AvaloniaList<Company> _companies;

    public AvaloniaList<Company> Companies
    {
        get => _companies;
        set => SetField(ref _companies, value);
    }

    public CompanyViewModel()
    {
        Companies = new AvaloniaList<Company>();
        LoadCompanies();
    }

    private void LoadCompanies()
    {
        using (var dbContext = new YourDbContext()) 
        {
            var companies = dbContext.Company.ToList();
            Companies = new(companies);
        }

    }
}

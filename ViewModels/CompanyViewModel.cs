using System.Collections.ObjectModel;
using System.Linq;
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
        LoadCompanies();
    }

    private void LoadCompanies()
    {
        using (var dbContext = new YourDbContext()) // Инициализация контекста базы данных
        {
            var companies = dbContext.Companies.ToList(); // Загрузка всех компаний из базы данных
            foreach (var company in companies)
            {
                Companies.Add(company); // Добавление компаний в коллекцию Companies
            }
        }

    }
}

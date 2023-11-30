using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Project3.Models;
using Project3.ViewModels;

namespace Project3;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new RiskViewModel();
        DataContext = new CompanyViewModel();
        DataContext = new StrategyViewModel();
        DataContext = new RiskCategoryViewModel();
        DataContext = new ImpactViewModel();
        DataContext = new RiskMitigationViewModel();
        DataContext = new ThreatPreventionViewModel();
    }

    private void CloseButton_OnClick(object? sender, RoutedEventArgs e)
    {
       this.Close();
    }
    

    private void EditCompanyButton_OnClick(object? sender, RoutedEventArgs e)
    {
        EditOrAddCompanyWindow editCompanyWindow = new EditOrAddCompanyWindow()
        {
            id = (CompanyGrid.SelectedItem as Company).CompanyID
        };
        editCompanyWindow.Show();
    }

    private void EditRiskButton_OnClickButton_OnClick(object? sender, RoutedEventArgs e)
    {
        
    }


    private void EditStrategyButton_OnClick(object? sender, RoutedEventArgs e)
    {

    }

    private void DeleteRiskButton_OnClick(object? sender, RoutedEventArgs e)
    {

    }



    private void DeleteStrategyButton_OnClick(object? sender, RoutedEventArgs e)
    {

    }

    private void SearchRiskTextBox_OnTextChanging(object? sender, TextChangingEventArgs e)
    {
        
    }
}
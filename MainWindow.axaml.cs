using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Project3.EditAddDelete;
using Project3.Models;
using Project3.ViewModels;

namespace Project3;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
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
        EditOrAddStrategyWindow editOrAddStrategyWindow = new EditOrAddStrategyWindow()
        {
            id = (StrategyGrid.SelectedItem as Strategy).StrategyID
        };
        editOrAddStrategyWindow.Show();
    }

    private void DeleteRiskButton_OnClick(object? sender, RoutedEventArgs e)
    {
        if (RiskGrid.SelectedItem is not Risk risk) return;
        
        using var db = new YourDbContext();
        db.Risk.Remove(risk);
        
        if (DataContext is not MainWindowViewModel viewModel) return;

        viewModel.RiskViewModel.Risks.Remove(risk);
    }



    private void DeleteStrategyButton_OnClick(object? sender, RoutedEventArgs e)
    {

    }


}

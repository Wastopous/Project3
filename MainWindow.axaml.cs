using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
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
    }

    private void CloseButton_OnClick(object? sender, RoutedEventArgs e)
    {
       this.Close();
    }

    private void EditButton_OnClick(object? sender, RoutedEventArgs e)
    {
        
    }

    private void AddButton_OnClick(object? sender, RoutedEventArgs e)
    {

    }

    private void DeleteButton_OnClick(object? sender, RoutedEventArgs e)
    {
        
    }
}
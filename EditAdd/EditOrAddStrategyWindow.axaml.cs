using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Project3.Models;
using Project3.ViewModels;

namespace Project3.EditAddDelete;

public partial class EditOrAddStrategyWindow : Window
{
    public EditOrAddStrategyWindow()
    {
        InitializeComponent();
    }
    public int id { get; set; } = 0;

    private void SaveBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        var db = new YourDbContext();
        var strategy = new Strategy()
        {
            StrategyName = NewName.Text, StrategyDescription = NewDescription.Text
        };
        
        if (id == 0)
        {
            db.Strategy.Attach(strategy);
            db.Strategy.Add(strategy);
        }
        else
        {
            strategy.StrategyID = id;
            db.Strategy.Update(strategy);
        }
        db.SaveChanges();
        Close();
    }

    private void CancelBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        Close();
    }
}
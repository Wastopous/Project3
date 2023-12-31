﻿using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Project3.Models;
using Project3.ViewModels;

namespace Project3;

public partial class EditOrAddCompanyWindow : Window
{
    public EditOrAddCompanyWindow()
    {
        InitializeComponent();
    }
    public int id { get; set; } = 0;

    private void SaveBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        var db = new YourDbContext();
        var company = new Company()
        {
            CompanyName = NewName.Text, CompanyDescription = NewDescription.Text
        };
        
        if (id == 0)
        {
            db.Company.Attach(company);
            db.Company.Add(company);
        }
        else
        {
            company.CompanyID = id;
            db.Company.Update(company);
        }
        db.SaveChanges();
        Close();
    }

    private void CancelBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        this.Close();
    }

    
}
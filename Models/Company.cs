using System.ComponentModel.DataAnnotations;
using Avalonia.Remote.Protocol.Input;

namespace Project3.Models;

public class Company
{
    [Key] public int CompanyID { get; set; }
    public string CompanyName { get; set; }
    public string CompanyDescription { get; set; }
}
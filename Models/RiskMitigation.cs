using System.ComponentModel.DataAnnotations;
namespace Project3.Models;

public class RiskMitigation
{
    [Key] public int RislMitigationID { get; set; }
    public string RiskMitigationName { get; set; }
    public string RiskMitigationDescription { get; set; }
}
using System.ComponentModel.DataAnnotations;

namespace Project3.Models;

public class RiskCategory
{
    [Key]public int RiskCategoryID { get; set; }
    public string RiskCategoryName { get; set; }
    public string RiskCategoryDescription { get; set; }
}
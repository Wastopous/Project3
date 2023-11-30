using System.ComponentModel.DataAnnotations;

namespace Project3.Models;

public class Impact
{
    [Key]public int ImpactID { get; set; }
    public int ImpactAmount { get; set; }
    public string ImpactDescription { get; set; }
}
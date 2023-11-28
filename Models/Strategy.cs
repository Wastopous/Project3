using System.ComponentModel.DataAnnotations;

namespace Project3.Models;

public class Strategy
{
    [Key]public int StrategyID { get; set; }
    public string StrategyName { get; set; }
    public string StrategyDescription { get; set; }


}
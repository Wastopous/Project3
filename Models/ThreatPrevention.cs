using System.ComponentModel.DataAnnotations;

namespace Project3.Models;

public class ThreatPrevention
{
    [Key] public int ThreatPreventionID { get; set; }
    public string ThreatPreventionName { get; set; }
    public string ThreatPreventionDescription { get; set; }
}
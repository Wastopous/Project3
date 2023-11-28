using System.ComponentModel.DataAnnotations;

namespace Project3.Models;

public class Risk
{
    [Key]public int RiskID { get; set; }
    public Impact Impact { get; set; }
    public Company Company { get; set; }
    public string RiskDescription { get; set; }
    public Strategy Strategy { get; set; }
    public RiskCategory RiskCategory { get; set; }
    public RiskMitigation RiskMitigation { get; set; }
    public ThreatPrevention ThreatPrevention { get; set; }
}
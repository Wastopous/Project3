namespace Project3.Models;

public class Risk
{
    public int RiskID { get; set; }
    public string RiskDescription { get; set; }

    public Risk(int riskId, string riskDescription)
    {
        this.RiskID = riskId;
        this.RiskDescription = riskDescription;

    }
}
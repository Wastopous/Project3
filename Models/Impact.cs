namespace Project3.Models;

public class Impact
{
    public int ImpactID { get; set; }
    public int ImpactAmount { get; set; }
    public string ImpactDescription { get; set; }

    public Impact(int impactId, int impactAmount, string impactDescription)
    {
        this.ImpactID = impactId;
        this.ImpactAmount = impactAmount;
        this.ImpactDescription = impactDescription;
    }
}
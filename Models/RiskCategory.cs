namespace Project3.Models;

public class RiskCategory
{
    public int RiskCategoryID { get; set; }
    public string RiskCategoryName { get; set; }
    public string RiskCategoryDescription { get; set; }

    public RiskCategory(int riskCategoryId, string riskCategoryName, string riskCategoryDescription)
    {
        this.RiskCategoryID = riskCategoryId;
        this.RiskCategoryName = riskCategoryName;
        this.RiskCategoryDescription = riskCategoryDescription;
    }
}
namespace Project3.Models;

public class Company
{
    public int CompanyID { get; set; }
    public string CompanyName { get; set; }
    public string CompanyDescription { get; set; }

    public Company(int companyId, string companyName, string companyDescription)
    {
        this.CompanyID = companyId;
        this.CompanyName = companyName;
        this.CompanyDescription = companyDescription;
    }
}
namespace Project3.Models;

public class Strategy
{
    public int StrategyID { get; set; }
    public string StrategyName { get; set; }
    public string StrategyDescription { get; set; }

    public Strategy(int strategyId, string strategyName, string strategyDescription)
    {
        this.StrategyID = strategyId;
        this.StrategyName = strategyName;
        this.StrategyDescription = strategyDescription;
    }
}
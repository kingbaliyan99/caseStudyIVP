using System.ComponentModel.DataAnnotations;


    public class Equity
    {
    [Key]
    public int SecurityId { get; set; }
    [Required]
    public string SecurityName { get; set; } = String.Empty;
    public string? SecurityDescription { get; set; }
    public bool HasPosition { get; set; }
    public bool IsActiveSecurity { get; set; }
    public int LotSize { get; set; }
    public string? BBGUniqueName { get; set; }
    public string? CUSIP { get; set; }
    public string? ISIN { get; set; }
    public string? SEDOL { get; set; }
    public string? BloombergTicker { get; set; }
    public string? BloombergUniqueID { get; set; }
    public string? BBGGlobalID { get; set; }
    public string? TickerAndExchange { get; set; }
    public bool IsADRFlag { get; set; }
    public string? ADRUnderlyingTicker { get; set; }
    public string? ADRUnderlyingCurrency { get; set; }
    public int SharesPerADR { get; set; }
    public DateTime IPODate { get; set; }
    public string? PricingCurrency { get; set; }
    public int SettleDays { get; set; }
    public long TotalSharesOutstanding { get; set; }
    public int VotingRightsPerShare { get; set; }
    public long AverageVolume20D { get; set; }
    public double Beta { get; set; }
    public double ShortInterest { get; set; }
    public double ReturnYTD { get; set; }
    public double Volatility90D { get; set; }
    public string? PFAssetClass { get; set; }
    public string? PFCountry { get; set; }
    public string? PFCreditRating { get; set; }
    public string? PFCurrency { get; set; }
    public string? PFInstrument { get; set; }
    public string? PFLiquidityProfile { get; set; }
    public string? PFMaturity { get; set; }
    public string? PFNAICSCode { get; set; }
    public string? PFRegion { get; set; }
    public string? PFSector { get; set; }
    public string? PFSubAssetClass { get; set; }
    public string? CountryOfIssuance { get; set; }
    public string? Exchange { get; set; }
    public string? Issuer { get; set; }
    public string? IssueCurrency { get; set; }
    public string? TradingCurrency { get; set; }
    public string? BBGIndustrySubGroup { get; set; }
    public string? BloombergIndustryGroup { get; set; }
    public string? BloombergSector { get; set; }
    public string? CountryOfIncorporation { get; set; }
    public string? RiskCurrency { get; set; }
    public double OpenPrice { get; set; }
    public double ClosePrice { get; set; }
    public long Volume { get; set; }
    public double LastPrice { get; set; }
    public double AskPrice { get; set; }
    public double BidPrice { get; set; }
    public double PERatio { get; set; }
    public DateTime DividendDeclaredDate { get; set; }
    public DateTime DividendExDate { get; set; }
    public DateTime DividendRecordDate { get; set; }
    public DateTime DividendPayDate { get; set; }
    public double DividendAmount { get; set; }
    public string? Frequency { get; set; }
    public string? DividendType { get; set; }
    }
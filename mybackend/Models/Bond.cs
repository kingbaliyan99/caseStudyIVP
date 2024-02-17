using System.ComponentModel.DataAnnotations;

    public class Bond
        {
        [Key]
        public int SecurityId { get; set; }
        public string? SecurityDescription { get; set; }
        [Required]
        public string SecurityName { get; set; } = String.Empty;
        public string? AssetType { get; set; }
        public string? InvestmentType { get; set; }
        public double TradingFactor { get; set; }
        public double PricingFactor { get; set; }
        public string? ISIN { get; set; }
        public string? BBGTicker { get; set; }
        public string? BBGUniqueID { get; set; }
        public string? CUSIP { get; set; }
        public string? SEDOL { get; set; }
        public DateTime FirstCouponDate { get; set; }
        public double Cap { get; set; }
        public double Floor { get; set; }
        public string? CouponFrequency { get; set; }
        public double Coupon { get; set; }
        public string? CouponType { get; set; }
        public double Spread { get; set; }
        public bool CallableFlag { get; set; }
        public bool FixToFloatFlag { get; set; }
        public bool PutableFlag { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime LastResetDate { get; set; }
        public DateTime Maturity { get; set; }
        public int CallNotificationMaxDays { get; set; }
        public int PutNotificationMaxDays { get; set; }
        public DateTime PenultimateCouponDate { get; set; }
        public string? ResetFrequency { get; set; }
        public bool HasPosition { get; set; }
        public double MacaulayDuration { get; set; }
        public double Volatility30D { get; set; }
        public double Volatility90D { get; set; }
        public double Convexity { get; set; }
        public long AverageVolume30Day { get; set; }
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
        public string? BloombergIndustryGroup { get; set; }
        public string? BloombergIndustrySubGroup { get; set; }
        public string? BloombergIndustrySector { get; set; }
        public string? CountryOfIssuance { get; set; }
        public string? IssueCurrency { get; set; }
        public string? Issuer { get; set; }
        public string? RiskCurrency { get; set; }
        public DateTime PutDate { get; set; }
        public double PutPrice { get; set; }
        public double AskPrice { get; set; }
        public double HighPrice { get; set; }
        public double LowPrice { get; set; }
        public double OpenPrice { get; set; }
        public long Volume { get; set; }
        public double BidPrice { get; set; }
        public double LastPrice { get; set; }
        public DateTime CallDate { get; set; }
        public double CallPrice { get; set; }
    }
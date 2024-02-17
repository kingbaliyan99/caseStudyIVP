using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mybackend.Migrations
{
    /// <inheritdoc />
    public partial class InitialM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bonds",
                columns: table => new
                {
                    SecurityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SecurityDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssetType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvestmentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TradingFactor = table.Column<double>(type: "float", nullable: false),
                    PricingFactor = table.Column<double>(type: "float", nullable: false),
                    ISIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BBGTicker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BBGUniqueID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CUSIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEDOL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstCouponDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cap = table.Column<double>(type: "float", nullable: false),
                    Floor = table.Column<double>(type: "float", nullable: false),
                    CouponFrequency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coupon = table.Column<double>(type: "float", nullable: false),
                    CouponType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Spread = table.Column<double>(type: "float", nullable: false),
                    CallableFlag = table.Column<bool>(type: "bit", nullable: false),
                    FixToFloatFlag = table.Column<bool>(type: "bit", nullable: false),
                    PutableFlag = table.Column<bool>(type: "bit", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastResetDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Maturity = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CallNotificationMaxDays = table.Column<int>(type: "int", nullable: false),
                    PutNotificationMaxDays = table.Column<int>(type: "int", nullable: false),
                    PenultimateCouponDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResetFrequency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasPosition = table.Column<bool>(type: "bit", nullable: false),
                    MacaulayDuration = table.Column<double>(type: "float", nullable: false),
                    Volatility30D = table.Column<double>(type: "float", nullable: false),
                    Volatility90D = table.Column<double>(type: "float", nullable: false),
                    Convexity = table.Column<double>(type: "float", nullable: false),
                    AverageVolume30Day = table.Column<long>(type: "bigint", nullable: false),
                    PFAssetClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PFCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PFCreditRating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PFCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PFInstrument = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PFLiquidityProfile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PFMaturity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PFNAICSCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PFRegion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PFSector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PFSubAssetClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloombergIndustryGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloombergIndustrySubGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloombergIndustrySector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryOfIssuance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssueCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Issuer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RiskCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PutPrice = table.Column<double>(type: "float", nullable: false),
                    AskPrice = table.Column<double>(type: "float", nullable: false),
                    HighPrice = table.Column<double>(type: "float", nullable: false),
                    LowPrice = table.Column<double>(type: "float", nullable: false),
                    OpenPrice = table.Column<double>(type: "float", nullable: false),
                    Volume = table.Column<long>(type: "bigint", nullable: false),
                    BidPrice = table.Column<double>(type: "float", nullable: false),
                    LastPrice = table.Column<double>(type: "float", nullable: false),
                    CallDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CallPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bonds", x => x.SecurityId);
                });

            migrationBuilder.CreateTable(
                name: "Equities",
                columns: table => new
                {
                    SecurityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SecurityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecurityDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasPosition = table.Column<bool>(type: "bit", nullable: false),
                    IsActiveSecurity = table.Column<bool>(type: "bit", nullable: false),
                    LotSize = table.Column<int>(type: "int", nullable: false),
                    BBGUniqueName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CUSIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEDOL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloombergTicker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloombergUniqueID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BBGGlobalID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TickerAndExchange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsADRFlag = table.Column<bool>(type: "bit", nullable: false),
                    ADRUnderlyingTicker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADRUnderlyingCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SharesPerADR = table.Column<int>(type: "int", nullable: false),
                    IPODate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PricingCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SettleDays = table.Column<int>(type: "int", nullable: false),
                    TotalSharesOutstanding = table.Column<long>(type: "bigint", nullable: false),
                    VotingRightsPerShare = table.Column<int>(type: "int", nullable: false),
                    AverageVolume20D = table.Column<long>(type: "bigint", nullable: false),
                    Beta = table.Column<double>(type: "float", nullable: false),
                    ShortInterest = table.Column<double>(type: "float", nullable: false),
                    ReturnYTD = table.Column<double>(type: "float", nullable: false),
                    Volatility90D = table.Column<double>(type: "float", nullable: false),
                    PFAssetClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PFCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PFCreditRating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PFCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PFInstrument = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PFLiquidityProfile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PFMaturity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PFNAICSCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PFRegion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PFSector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PFSubAssetClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryOfIssuance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Exchange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Issuer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssueCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TradingCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BBGIndustrySubGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloombergIndustryGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloombergSector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryOfIncorporation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RiskCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpenPrice = table.Column<double>(type: "float", nullable: false),
                    ClosePrice = table.Column<double>(type: "float", nullable: false),
                    Volume = table.Column<long>(type: "bigint", nullable: false),
                    LastPrice = table.Column<double>(type: "float", nullable: false),
                    AskPrice = table.Column<double>(type: "float", nullable: false),
                    BidPrice = table.Column<double>(type: "float", nullable: false),
                    PERatio = table.Column<double>(type: "float", nullable: false),
                    DividendDeclaredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DividendExDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DividendRecordDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DividendPayDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DividendAmount = table.Column<double>(type: "float", nullable: false),
                    Frequency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DividendType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equities", x => x.SecurityId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bonds");

            migrationBuilder.DropTable(
                name: "Equities");
        }
    }
}

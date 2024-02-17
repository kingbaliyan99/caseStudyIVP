import React, { useState } from 'react';
import { BrowserRouter as Router, Link } from 'react-router-dom'; // Import BrowserRouter and Link
import { Tab, Tabs, Typography, Table, TableBody, TableCell, TableContainer, TableHead, TableRow, Paper } from '@mui/material';

const data = [
    {
      tabName: "Security",
      url: "/security",
      attributes: [
        "Security Name",
        "Security Description",
        "Has Position",
        "Is Active",
        "Round Lot Size",
        "Bloomberg Unique Name",
        "CUSIP",
        "ISIN",
        "SEDOL",
        "Bloomberg Ticker",
        "Bloomberg Unique ID",
        "Bloomberg Global ID",
        "Bloomberg Ticker and Exchange",
        "Is ADR",
        "ADR Underlying Ticker",
        "ADR Underlying Currency",
        "Shares Per ADR",
        "IPO Date",
        "Price Currency",
        "Settle Days",
        "Shares Outstanding",
        "Voting Rights Per Share",
        "20 Day Average Volume"
      ]
    },
    {
      tabName: "Risk",
      url: "/risk",
      attributes: [
        "Beta",
        "Short Interest",
        "YTD Return",
        "90 Day Price Volatility"
      ]
    },
    {
      tabName: "Regulatory Details",
      url: "/regulatory-details",
      attributes: [
        "Form PF Asset Class",
        "Form PF Country",
        "Form PF Credit Rating",
        "Form PF Currency",
        "Form PF Instrument",
        "Form PF Liquidity Profile",
        "Form PF Maturity",
        "Form PF NAICS Code",
        "Form PF Region",
        "Form PF Sector",
        "Form PF Sub Asset Class"
      ]
    },
    {
      tabName: "Reference Data",
      url: "/reference-data",
      attributes: [
        "Issue Country",
        "Exchange",
        "Issuer",
        "Issue Currency",
        "Trading Currency",
        "Bloomberg Industry Sub Group",
        "Bloomberg Industry Group",
        "Bloomberg Industry Sector",
        "Country of Incorporation",
        "Risk Currency"
      ]
    },
    {
      tabName: "Pricing Details",
      url: "/pricing-details",
      attributes: [
        "Open Price",
        "Close Price",
        "Volume",
        "Last Price",
        "Ask Price",
        "Bid Price",
        "PE Ratio"
      ]
    },
    {
      tabName: "Dividend History",
      url: "/dividend-history",
      attributes: [
        "Declared Date",
        "Ex Date",
        "Record Date",
        "Pay Date",
        "Amount",
        "Frequency",
        "Dividend Type"
      ]
    },
  ];
  

function TabbedAttributes() {
  const [activeTab, setActiveTab] = useState(0);

  const handleTabChange = (event, newValue) => {
    setActiveTab(newValue);
  };

  return (
    <Router> {/* Wrap your component with Router */}
      <div>
        <Tabs value={activeTab} onChange={handleTabChange}>
          {data.map((tab, index) => (
            <Tab key={index} label={tab.tabName} component={Link} to={tab.url} /> 
          ))}
        </Tabs>
        {data.map((tab, index) => (
          <div key={index} role="tabpanel" hidden={activeTab !== index}>
            {activeTab === index && (
              <div>
                <Typography variant="h6">{tab.tabName}</Typography>
                <TableContainer component={Paper}>
                  <Table>
                    <TableHead>
                      <TableRow>
                        {tab.attributes.map((attribute, index) => (
                          <TableCell key={index}><strong>{attribute}</strong></TableCell>
                        ))}
                      </TableRow>
                    </TableHead>
                    <TableBody>
                      <TableRow>
                        {tab.attributes.map((attribute, index) => (
                          <TableCell key={index}>{/* Render data from database */}</TableCell>
                        ))}
                      </TableRow>
                    </TableBody>
                  </Table>
                </TableContainer>
              </div>
            )}
          </div>
        ))}
      </div>
    </Router>
  );
}

export default TabbedAttributes;

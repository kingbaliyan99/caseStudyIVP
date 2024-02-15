import * as React from 'react';
import Table from '@mui/material/Table';
import TableBody from '@mui/material/TableBody';
import TableCell from '@mui/material/TableCell';
import TableContainer from '@mui/material/TableContainer';
import TableHead from '@mui/material/TableHead';
import TableRow from '@mui/material/TableRow';
import Paper from '@mui/material/Paper';

const headings = [
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
  "20 Day Average Volume",
  "Beta",
  "Short Interest",
  "YTD Return",
  "90 Day Price Volatility",
  "Form PF Asset Class",
  "Form PF Country",
  "Form PF Credit Rating",
  "Form PF Currency"
];

export default function Table2() {
  return (
    <TableContainer component={Paper}>
      <Table sx={{ minWidth: 650 }} size="small" aria-label="a dense table">
        <TableHead>
          <TableRow>
            {headings.map((heading, index) => (
              <TableCell key={index} sx={{ fontWeight: 'bold' }}>{heading}</TableCell>
            ))}
          </TableRow>
        </TableHead>
        <TableBody>
          {/* Rows go here */}
        </TableBody>
      </Table>
    </TableContainer>
  );
}

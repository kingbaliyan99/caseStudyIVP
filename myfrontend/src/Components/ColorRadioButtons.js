import React, { useState } from 'react';
import { Link } from 'react-router-dom';
import { RadioGroup, Radio, FormControlLabel, Box } from '@mui/material';

function ColorRadioButtons() {
  const [selectedValue, setSelectedValue] = useState('');

  const handleChange = (event) => {
    setSelectedValue(event.target.value);
  };

  return (
    <Box display="flex" justifyContent="center">
      <RadioGroup value={selectedValue} onChange={handleChange} row>
        <FormControlLabel
          value="red"
          control={<Radio color="primary" />}
          label="Red"
          labelPlacement="end"
          component={Link} to="/red-page" // Navigate to "/red-page" when clicked
        />
        <FormControlLabel
          value="blue"
          control={<Radio color="primary" />}
          label="Blue"
          labelPlacement="end"
          component={Link} to="/blue-page" // Navigate to "/blue-page" when clicked
        />
        {/* Add more radio buttons as needed */}
      </RadioGroup>
    </Box>
  );
}

export default ColorRadioButtons;

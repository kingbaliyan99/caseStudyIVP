import './App.css';
import ColorRadioButtons from './Components/ColorRadioButtons';

import TabbedAttributes from './Components/TabedAttributes';
import { BrowserRouter as Router, Route } from 'react-router-dom'; // Import BrowserRouter

function App() {
  return (
    
    <div className="App">
     <TabbedAttributes/>
    </div>
  );
}

export default App;

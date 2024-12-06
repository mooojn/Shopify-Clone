import React, { useEffect, useState } from 'react';
import '../styles/Header.css';

function Header() {
  const [headerColor, setHeaderColor] = useState(''); 
  const [logoText, setLogoText] = useState('');
  const [menuItems, setMenuItems] = useState([]);

  // Fetch the CSV file and set the logo text and menu items
  useEffect(() => {
    fetch('/data/header.csv')
      .then(response => response.text())
      .then(data => {
        const lines = data.split('\n')

        setHeaderColor(lines[0])
        setLogoText(lines[1])

        setMenuItems(lines.slice(2))
      })
      .catch(error => console.error('Error fetching the CSV file:', error))
  }, [])

  return (
    <div className='main-header' style={{background:headerColor}}>
      <div className='logo'>
        <a href="/"><p>{logoText}</p></a>
      </div>
      <div className='menu-items'>
        <ul>
          {menuItems.map((item) => <a href={item}><li>{item}</li></a>)}
        </ul>
      </div>
    </div>
  );
}

export default Header;

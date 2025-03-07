import './App.css';
import { useState } from 'react';
import Formulaire from './components/Formulaire';
import Affichage from './components/Affichage';

function App() {
  const [contacts, setContacts] = useState([]);

  const addContact = (contact) => {
    setContacts([...contacts, contact]);
  };

  return (
    <>
      <Formulaire addContact={addContact} />
      <Affichage contacts={contacts} />
    </>
  );
}

export default App;
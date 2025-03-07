import React, { useState } from 'react';
import ChildComponent from './ChildComponent';

const ParentComponent = () => {
    const [listeNombre, setListeNombre] = useState([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);

    const addNumberInList = () => {
        let rdmNumber = Math.floor(Math.random() * 100);
        setListeNombre([...listeNombre, rdmNumber]);
    }

    return ( 
        <>
            <ChildComponent listeNombre={listeNombre} />
            <button onClick={addNumberInList}>Valider</button>
        </>
    );
}

export default ParentComponent;
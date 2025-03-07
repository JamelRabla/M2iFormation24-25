import { useState } from "react";

const InputComp = () => {
    const [monPrenom, setMonPrenom] = useState("");
    const [monNom, setMonNom] = useState("");

    const changerPrenom = (e) => {
        setMonPrenom(e.target.value)
    }

    const changerNom = (e) => {
        setMonNom(e.target.value)
    }

    const getName = () => {
        return (monPrenom + " " + monNom.toUpperCase() )    
    }

    console.log("test");
    return ( 
        <>
            <input type="text" value={monPrenom} onInput={changerPrenom} placeholder="Entrez votre Prenom"/>
            <input type="text" value={monNom} onInput={changerNom} placeholder="Entrez votre Nom"/>
            <p>Bonjour, <b>{getName()}</b>, Bienvenue</p>
        </>
     );
}
 
export default InputComp;
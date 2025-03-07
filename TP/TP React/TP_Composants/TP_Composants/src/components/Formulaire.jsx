import { useState } from "react";

const Formulaire = ({ addContact }) => {
    const [prenom, setPrenom] = useState("");
    const [nom, setNom] = useState("");
    const [mail, setMail] = useState("");

    const sendContact = () => {
        const contact = { prenom, nom, mail };
        addContact(contact);
    };

    return (
        <>
            <input type="text" value={nom} onInput={(e) => setNom(e.target.value)} placeholder="Nom" />
            <input type="text" value={prenom} onInput={(e) => setPrenom(e.target.value)} placeholder="Prénom" />
            <input type="text" value={mail} onInput={(e) => setMail(e.target.value)} placeholder="E-mail" />
            <button onClick={sendContact}>Valider</button>
        </>
    );
};

export default Formulaire;
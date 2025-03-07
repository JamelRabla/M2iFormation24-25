const Affichage = ({ contacts }) => {
    return (
        <>
            {contacts.length === 0 ? (
                <p>Aucun contact dans la liste</p>
            ) : (
                <ul>
                    {contacts.map((contact, index) => (
                        <li key={index}>
                            {contact.nom} {contact.prenom} ({contact.mail})
                        </li>
                    ))}
                </ul>
            )}
        </>
    );
};

export default Affichage;
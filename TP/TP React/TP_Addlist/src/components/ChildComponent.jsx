import React from 'react';

const ChildComponent = ({ listeNombre }) => {
    return (
        <div>
            <h2>Child Component</h2>
            <ul>
                {listeNombre.map((nombre, index) => {
                    return <li key={index}>{nombre}</li>
                })}
            </ul>
        </div>
    );
}

export default ChildComponent;
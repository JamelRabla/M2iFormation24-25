let currentPokemonId = 1;

async function fetchPokemonData(id) {
    try {
        const response = await fetch(`https://pokeapi.co/api/v2/pokemon/${id}`);
        const data = await response.json();
        displayPokemonData(data);
    } catch (error) {
        console.error('Erreur lors de la récupération des données du Pokémon:', error);
    }
}

async function fetchPokemonByName(name) {
    try {
        const response = await fetch(`https://pokeapi.co/api/v2/pokemon/${name}`);
        const data = await response.json();
        currentPokemonId = data.id;
        displayPokemonData(data);
    } catch (error) {
        console.error('Erreur lors de la récupération des données du Pokémon:', error);
    }
}

function displayPokemonData(pokemon) {
    document.getElementById('name').textContent = pokemon.name;
    document.getElementById('height').textContent = pokemon.height;
    document.getElementById('weight').textContent = pokemon.weight;
    document.getElementById('type').textContent = pokemon.types.map(typeInfo => typeInfo.type.name).join(', ');
    document.getElementById('moves').textContent = pokemon.moves.map(moveInfo => moveInfo.move.name).slice(0, 2).join(', ');
    document.getElementById('pokemon-image').src = pokemon.sprites.front_default;
}

document.getElementById('next-button').addEventListener('click', () => {
    currentPokemonId += 1;
    fetchPokemonData(currentPokemonId);
});

document.getElementById('prev-button').addEventListener('click', () => {
    if (currentPokemonId > 1) {
        currentPokemonId -= 1;
        fetchPokemonData(currentPokemonId);
    }
});

document.getElementById('pokemon-search').addEventListener('keypress', (event) => {
    if (event.key === 'Enter') {
        const pokemonName = event.target.value.toLowerCase();
        fetchPokemonByName(pokemonName);
    }
});

fetchPokemonData(currentPokemonId);

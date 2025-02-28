const chiffre = document.querySelector('.chiffre');
const result = document.querySelector('.result');
const reload = document.querySelector('.reload');
const tenta = document.querySelector('.tenta');
const valider = document.querySelector('.valider');

let chiffreMystere;
let tentative = 0;
let trouve = false;

function startGame() {
    chiffreMystere = Math.floor(Math.random() * 50) + 1;
    console.log(chiffreMystere);
};

function rejouer() {
  reload.innerHTML = "<button onclick='window.location.reload();'>Rejouer</button>";
}

function verifierChiffre() {

    if (chiffre.value === "") {
        result.innerHTML = "Veuillez entrer un chiffre / nombre.";
        return;
    } else if (chiffre.value < 1 || chiffre.value > 50) {
        result.innerHTML = "Veuillez entrer une valeur entre 1 et 50.";
        return;
    }
    
    tentative++;

    if (parseInt(chiffre.value) === chiffreMystere) {
        
        result.innerHTML = "Bravo ! Vous avez trouvé le chiffre mystère " + chiffreMystere + " en " + tentative + " tentatives.";
        trouve = true;

        rejouer();

    } else if (parseInt(chiffre.value) < chiffreMystere) {
        tenta.innerHTML = "<p>Tentative : " + tentative + "/10</p>";
        result.innerHTML = "C'est plus !";

    } else {
        tenta.innerHTML = "<p>Tentative : " + tentative + "/10</p>";
        result.innerHTML = "C'est moins !";
    }

    if (trouve || tentative >= 10) {
        valider.disabled = true;
        result.innerHTML += " Le jeu est terminé.";
    
        rejouer();
    }
}

window.onload = startGame;



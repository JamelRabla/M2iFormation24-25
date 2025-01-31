let chiffreMystere = Math.floor(Math.random() * 100) + 1;

let tentative = 0;
let trouve = false;

alert("Bienvenue au jeu du chiffre mystère !");
alert("Devinez un chiffre entre 1 et 100.");

do{
  let saisie = prompt("Entrez votre chiffre : ");
  let chiffre = parseInt(saisie, 10);

  if (isNaN(chiffre)) {
    alert("Veuillez entrer un nombre valide.");
    continue;
  }
  tentative++;

  if (chiffre === chiffreMystere) {
    alert("Bravo ! Vous avez trouvé le chiffre mystère "+chiffreMystere + " en "+ tentative +" tentatives.");
    trouve = true;

  } else if (chiffre < chiffreMystere) {
    alert("C'est plus !");

  }else {
    alert("C'est moins !");
  }
}while(!trouve && tentative < 10)
alert("Merci d'avoir joué !");
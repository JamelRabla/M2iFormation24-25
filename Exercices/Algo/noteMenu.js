let min = 0
let max = 0
let moyenne = 0
let x =0 


for(let i = 1; i < 6; i++){
    x = Number(prompt("Entrez 5 note :"))
    if(i == 1){
        min = x
        max = x
    }
    if(x<min){
        min = x
    }
    else if(x>max){
        max = x
    }
    moyenne += x
 }

let menu = prompt("1 - afficher la plus petite note \n2 - afficher la plus grande note \n3 - afficher la moyenne ")

switch(menu){
    case "1":
        console.log(min);
        break;
    case "2":
        console.log(max);
        break;
    case "3":
        console.log(moyenne / 5);
        break;
    default: 

    }
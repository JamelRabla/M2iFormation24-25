function tablist(){
    let tab = []
    let max = 0
    let min = 0
    let moyenne = 0
    let a = 0
    let x = prompt("Combien de note voulez vous calculer ?")

    for (let i = 1; i <= x; i++) {
         a = Number(prompt("Entrez un chiffre"));
        tab.push(a)
        if(i == 1){
            min = a
            max = a
        }
        if(a<min){
            min = a
        }
        else if(a>max){
            max = a
        }
        moyenne += a / x
        
     }
     for (let i = 1; i <= x; i++){
     console.log("Note: ", tab[i])
    }
     console.log("le max est : ", max,"\nLe min est : ", min,"\nLa moyenne est : ",moyenne);
}

tablist();
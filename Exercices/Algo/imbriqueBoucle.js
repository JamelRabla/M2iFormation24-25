let n = 2
let m = 2
let note = []
let tab = ["Math", "Art", "Anglais"]
let a

for (let i = 0; i <= n; i++) {    
    note[i] = []
    for (let j = 0; j <= m; j++){
        a = prompt("Note de l'etudiant: ", note[i+1], " dans la Matiere: " , note[j+1])
        note[i][j]= a
    }
 }

console.log("Note :" ,tab, note);
using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;
using Microsoft.EntityFrameworkCore;
using personnage.Data;
using personnage.Models;

using var context = new AppDbContext();
bool boucle = true;

while (boucle)
{
    Console.WriteLine(@"
  ____                     _   _                  
 |  _ \ ___ _ __ ___  ___ | \ | | __ _  __ _  ___ 
 | |_) / _ \ '__/ __|/ _ \|  \| |/ _` |/ _` |/ _ \
 |  __/  __/ |  \__ \ (_) | |\  | (_| | (_| |  __/
 |_|   \___|_|  |___/\___/|_| \_|\__,_|\__, |\___|
                                       |___/       
");

    Console.Write("=====Menu=====\n" +
                  "1. Crée un personnage\n" +
                  "2. Modifier un personnage\n" +
                  "3. Lister tout les personnages\n" +
                  "4. Taper un personnage\n" +
                  "5. Afficher les personnage > Moyenne de vie\n" +
                  "6. Supprimer un personnage\n" +
                  "0. Quitter\n" +
                  "\nFaites votre choix : ");

    int choixMenu = Convert.ToInt32(Console.ReadLine());

    switch (choixMenu)
    {
        case 1:
            Console.Clear();
            AddPerso();
            break;

        case 2:
            Console.Clear();
            ModifPerso();
            break;

        case 3:
            Console.Clear();
            AfficherListPerso();
            break;

        case 4:
            Console.Clear();
            TaperPersonnage();
            break;

        case 5:
            Console.Clear();
            SupMoyenneVie();
            break;

        case 6:
            Console.Clear();
            SupprPerso();
            break;
        case 0:
            context.SaveChanges();
            boucle = false;
            break;

        default:
            Console.WriteLine("Valeur inconnu");
            break;
    }
}

Console.WriteLine("\n====== GOOD BYE ======");



// METHODE //

// TAPER UN PERSONNAGE & MORT DU PERSONNAGE
void TaperPersonnage()
{
    using var context = new AppDbContext();

    Console.Write("Selectionner le personnage qui attaque (by id) : ");
    int attaquant = Convert.ToInt32(Console.ReadLine());
    var attk = context.Personnages.Find(attaquant);

    Console.Write("Selectionner le personnage qui subis (by id) : ");
    int def = Convert.ToInt32(Console.ReadLine());
    var subis = context.Personnages.Find(def);

    if (subis.Armure == 0)
    {
        subis.PointsDeVie -= attk.Degats;
    }
    else
    {
        subis.Armure -= attk.Degats;
    }

    if (subis.Armure == 0 && subis.PointsDeVie == 0)
    {
        context.Personnages.Remove(subis);
        attk.Kills++;
    }

    context.SaveChanges();
}

// ADD PERSONNAGE
void AddPerso()
{
    using var context = new AppDbContext();

    Console.Write("Entrez votre pseudo pour crée votre personnage : ");
    string perso = Console.ReadLine();

    var newPerso = new Personnage()
    {
        Pseudo = perso,
        PointsDeVie = 100,
        Armure = 100,
        Degats = 10,
        DateCreation = DateTime.Now,
        Kills = 0
    };

    context.Personnages.Add(newPerso);
    context.SaveChanges();
}

// SUPPRIMER PERSONNAGE 

void SupprPerso()
{
    using var context = new AppDbContext();

    context.Personnages.ToList().ForEach(l => Console.WriteLine($"{l.id} | {l.Pseudo}"));

    Console.Write("Quel perso voulez vous supprimez (By Id) : ");
    int choixSuppr = Convert.ToInt32(Console.ReadLine());

    var suppr = context.Personnages.Find(choixSuppr);
    context.Personnages.Remove(suppr);

    context.SaveChanges();
}

// Lister perso
void AfficherListPerso()
{
    using var context = new AppDbContext();

    Console.WriteLine("====================");
    context.Personnages.ToList().ForEach(l => Console.WriteLine($"ID : {l.id} | Pseudo : {l.Pseudo} | {l.Kills} Kills"));
    Console.WriteLine("====================");
}

// Modif perso
void ModifPerso()
{
    using var context = new AppDbContext();

    Console.Clear();
    context.Personnages.ToList().ForEach(l => Console.WriteLine($"{l.id} | {l.Pseudo}"));

    Console.Write("Selectionnez un perso à modifier (by id) : \n");
    int idModif = Convert.ToInt32(Console.ReadLine());

    var modif = context.Personnages.Find(idModif);

    Console.Write("Entrez Votre Nouveau Pseudo : ");
    string newPseudo = Console.ReadLine();
    modif.Pseudo = newPseudo;

    Console.Write("Entrez Votre valeur d'armure : ");
    int newArmure = Convert.ToInt32(Console.ReadLine());
    modif.Armure = newArmure;

    Console.Write("Entrez Votre attaque : ");
    int newDegats = Convert.ToInt32(Console.ReadLine());
    modif.Degats = newDegats;

    context.SaveChanges();
}

// Moyenne vie
void SupMoyenneVie()
{
    using var context = new AppDbContext();

    Double moyenneVie = context.Personnages.Average(p => p.PointsDeVie + p.Armure);

    context.Personnages.Where(p => p.PointsDeVie + p.Armure > moyenneVie).ToList().ForEach(p => Console.WriteLine($"{p.Pseudo} à {p.PointsDeVie} points de vie et {p.Armure} points d'armure\n"));
    context.SaveChanges();
}
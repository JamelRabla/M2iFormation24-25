using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Demo01Bases.classe
{
    internal class Etudiant
    {

        private static string connectionString = "Data Source=(localdb)\\demo01ado;Initial Catalog=demo01ado;Integrated Security=True";
        int Id { get; set; }
        string Prenom { get; set; }
        string Nom { get; set; }
        int NumeroClasee { get; set; }
        DateTime DateDiplome { get; set; }

        public Etudiant(string prenom, string nom, int numeroClasee, DateTime dateDiplome)
        {
            Prenom = prenom;
            Nom = nom;
            NumeroClasee = numeroClasee;
            DateDiplome = dateDiplome;
        }

        public static List<Etudiant>GetEtudiants(int? numeroClasse = null)
        {

        }
    }
}

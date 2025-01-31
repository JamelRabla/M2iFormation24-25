namespace csharp.classe
{
    internal class Salarie
    {

        public decimal get => _salaire;
        set{

            }
        public string Prenom { get; set; } = "Salarié par défaut";
        public double Salaire { get; set; } = 1000;
        public string Categorie { get; set; } = string.Empty;
        public string Matricule { get; set; } = string.Empty;
        public string Service { get; set; } = string.Empty;

        private static int nombreTotalEmployes = 0;
        private static double salaireTotal = 0;

        public Salarie() : this("0000", "Salarié par défaut", 1000, string.Empty, string.Empty) { }

        public Salarie(string matricule, string prenom, double salaire, string categorie, string service)
        {
            Matricule = matricule;
            Prenom = prenom;
            Salaire = salaire;
            Categorie = categorie;
            Service = service;

            nombreTotalEmployes++;
            salaireTotal += salaire;
        }

        public override string ToString() => $"Le salaire de {Prenom} est de {Salaire} euros !";

        public static int NombreTotalEmployes() => nombreTotalEmployes;

        public static double SalaireTotal() => salaireTotal;

        public static void ResetEmploye()
        {
            nombreTotalEmployes = 0;
            salaireTotal = 0;
        }
    }
}
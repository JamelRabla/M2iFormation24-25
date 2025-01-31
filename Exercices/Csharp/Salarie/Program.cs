using csharp.classe;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(@"=== Gestion des employes ===
    1 - Ajouter un employe
    2 - Afficher le salaire des employe
    3 - Rechercher un employe");
        int menu = Convert.ToInt32(Console.ReadLine());

        switch(menu) {
            case 0:
                Environment.Exit(0);
                break;
            case 1:
                Console.WriteLine(@"=== Ajouter un employe ===
    1 - Salarie
    2 - Commercial
    3 - Retour");
                int menuAdd = Convert.ToInt32(Console.ReadLine());

                switch (menuAdd)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:

                }
                break;
            case 2:
                break;
            case 3:
                break;
    }
}


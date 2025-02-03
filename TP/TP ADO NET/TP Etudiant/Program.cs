using Microsoft.Data.SqlClient;
using System.Data;
using Demo01Bases.classe;

string connectionString = "Data Source=(localdb)\\demo01ado;Initial Catalog=demo01ado;Integrated Security=True";

Console.Write("Entrez un prenom : ");
string prenom = Console.ReadLine()!;

Console.Write("Entrez un nom : ");
string nom = Console.ReadLine()!;

Console.Write("Entrez un numéro de classe : ");
int numeroClasee = Int32.Parse((Console.ReadLine()))!;

Console.Write("Entrez une date de diplome (YYYY MM DD) : ");
DateTime dateDiplome = DateTime.Parse(Console.ReadLine()!);

//Add Etudiant
using (SqlConnection conn = new SqlConnection(connectionString))
{
    conn.Open();

    string query = "INSERT INTO Etudiant (prenom, nom, numeroClasee, dateDiplome) VALUES (@prenom, @nom, @numeroClasee, @dateDiplome)";

    using (SqlCommand sqlCommand = new SqlCommand(query, conn))
    {
        sqlCommand.Parameters.AddWithValue("@prenom", prenom);
        sqlCommand.Parameters.AddWithValue("@nom", nom);
        sqlCommand.Parameters.AddWithValue("@numeroClasee", numeroClasee);
        sqlCommand.Parameters.AddWithValue("@dateDiplome", dateDiplome);

        int insertion = sqlCommand.ExecuteNonQuery();
        Console.WriteLine($"{insertion} ligne insérée.\n=================\n");
    }
    conn.Close();
}


//Afficher total etudiant
using (SqlConnection conn = new SqlConnection(connectionString))
{
    conn.Open();

    string request = "SELECT id, prenom, nom, numeroClasee FROM Etudiant;";

    using (SqlCommand sqlCommand = new SqlCommand(request, conn))
    {
        SqlDataReader reader = sqlCommand.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"id : {reader.GetInt32(0)} | prenom: {reader.GetString(1)} | nom: {reader.GetString(2)}  | Classe : {reader.GetInt32(3)}\n");
        }
    }
    conn.Close();
}

//Delete etudiant

Console.Write("Selectionnez un etudiant à supprimer (by id) : ");
int id = Int32.Parse(Console.ReadLine())!;

using (SqlConnection conn = new SqlConnection(connectionString))
{
    conn.Open();
    string request = "DELETE FROM Etudiant WHERE id = @id;";
    using (SqlCommand sqlCommand = new SqlCommand(request, conn))
    {
        sqlCommand.Parameters.AddWithValue("@id", id);
        int deletion = sqlCommand.ExecuteNonQuery();
        Console.WriteLine($"{deletion} ligne supprimée.\n================\n");
    }
    conn.Close();
}

//Etudiant d'une classe
Console.Write("Selectionnez un numéro de classe : ");
int numeroClasse = Int32.Parse(Console.ReadLine())!;

using (SqlConnection conn = new SqlConnection(connectionString))
{
    conn.Open();

    string request = "SELECT id, prenom, nom, numeroClasee FROM Etudiant WHERE numeroClasee = @numeroClasse";

    using (SqlCommand sqlCommand = new SqlCommand(request, conn))
    {

        sqlCommand.Parameters.AddWithValue("@numeroClasse", numeroClasse);
        SqlDataReader reader = sqlCommand.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"id : {reader.GetInt32(0)} | prenom: {reader.GetString(1)} | nom: {reader.GetString(2)}  | Classe : {reader.GetInt32(3)}\n");
        }
    }
    conn.Close();
}


//Update etudiant
Console.Write("Selectionnez un etudiant à modifier (by id) : ");
int idUpdate = Int32.Parse(Console.ReadLine())!;

Console.Write("Entrez un prenom : ");
string prenomUpdate = Console.ReadLine()!;

Console.Write("Entrez un nom : ");
string nomUpdate = Console.ReadLine()!;

Console.Write("Entrez un numéro de classe : ");
int numeroClaseeUpdate = Int32.Parse((Console.ReadLine()))!;

Console.Write("Entrez une date de diplome (YYYY MM DD) : ");
DateTime dateDiplomeUpdate = DateTime.Parse(Console.ReadLine()!);

using (SqlConnection conn = new SqlConnection(connectionString))
{
    conn.Open();

    string query = "INSERT INTO Etudiant (prenom, nom, numeroClasee, dateDiplome) VALUES (@prenomUpdate, @nomUpdate, @numeroClaseeUpdate, @dateDiplomeUpdate)";

    using (SqlCommand sqlCommand = new SqlCommand(query, conn))
    {
        sqlCommand.Parameters.AddWithValue("@prenomUpdate", prenomUpdate);
        sqlCommand.Parameters.AddWithValue("@nomUpdate", nomUpdate);
        sqlCommand.Parameters.AddWithValue("@numeroClaseeUpdate", numeroClaseeUpdate);
        sqlCommand.Parameters.AddWithValue("@dateDiplomeUpdate", dateDiplomeUpdate);

        int insertion = sqlCommand.ExecuteNonQuery();
        Console.WriteLine($"{insertion} ligne insérée.\n=================\n");
    }
    conn.Close();
}

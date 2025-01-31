Console.Write("Veuillez saisir la hauteur du triangle : ");
int hauteur = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= hauteur; i++)
{
    for (int j = 1; j <= hauteur - i; j++)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= 2 * i - 1; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}


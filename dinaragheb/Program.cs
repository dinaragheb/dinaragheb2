Console.Write("Geben Sie eine ganze Zahl ein: ");
int n = int.Parse(Console.ReadLine());

// Überprüfen, ob die Zahl positiv, negativ oder null ist
if (n > 0)
{
    // Prüfen, ob es sich um eine Primzahl handelt
    bool istPrimzahl = true;

    if (n <= 1)
    {
        istPrimzahl = false;
    }
    else if (n == 2)
    {
        istPrimzahl = true;
    }
    else if (n % 2 == 0)
    {
        istPrimzahl = false;
    }
    else
    {
        // Überprüfen, ob n durch irgendeine ungerade Zahl von 3 bis zur Quadratwurzel von n teilbar ist
        for (int i = 3; i <= Math.Sqrt(n); i += 2)
        {
            if (n % i == 0)
            {
                istPrimzahl = false;
                break;
            }
        }
    }

    if (istPrimzahl)
    {
        Console.WriteLine($"{n} ist eine positive Primzahl.");
    }
    else
    {
        Console.WriteLine($"{n} ist eine positive Zahl, aber keine Primzahl.");
    }
}
else if (n < 0)
{
    Console.WriteLine($"{n} ist eine negative Zahl.");
}
else
{
    Console.WriteLine($"{n} ist null.");
}
   
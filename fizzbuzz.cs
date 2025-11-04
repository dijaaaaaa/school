//pmo fizz buzz mit schlaife 
//ERSTE BLOCHWOCHE
using System.Runtime.CompilerServices;

Console.WriteLine("----FIZZBUZZ----");
Console.WriteLine("\nWilkommen zur FIZZBUZZ");

Console.WriteLine("\nREGELN: ");
Console.WriteLine("Ich zähle bis 100 wenn die Nummer durch 3 teilbar ist sage ich FIZZ");
Console.WriteLine("Wenn es durch 5 teilbar ist sage ich BUZZ");
Console.WriteLine("Und wenn es durch beide Zahlen teilbar ist sage ich FIZZBUZZ");

Console.WriteLine("\nSind Sie bereit?");
Console.WriteLine("Bitte drucken Sie Taste [1] um zu satrten");

Console.WriteLine("\nMöchten Sie Ihre eigene Zahl einfugen?");
Console.WriteLine("Wenn ja [1]");
Console.WriteLine("Wenn nein [2]");
char antwort = Convert.ToChar(Console.ReadLine());
if (antwort == '1')
{
    Console.Clear();
    Console.WriteLine("Bitte geben Sie Ihre Zahl ein:");
    int fb = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    Console.WriteLine("Zahlen bis zu" + fb + ": ");
    for (int zahl = 0; zahl <= fb; zahl++) //zahlen gehen bis zu diese zahl 
    {
        string ergebniss = "";

        for (int i = 3; i <= 5; i += 2) //was komm raus wenn es durch 3 und 5 teilbar ist 
        {
            if (zahl % i == 0)
            {
                if (i == 3)
                {
                    ergebniss += "FIZZ:";
                }
                if (i == 5)
                {
                    ergebniss += "BUZZ:";
                }
            }
        }

        if (ergebniss == "")
        {
            Console.WriteLine(zahl);
        }
        else
        {
            Console.WriteLine(ergebniss);
        }

    }
}
else
{
    if (antwort == '2')
    {
        Console.Clear();
        Console.WriteLine("Zahlen bis zu 100:");
        for (int zahl = 0; zahl <= 100; zahl++) //0-100 schleife 
        {
            string ergebniss = "";

            for (int i = 3; i <= 5; i += 2) //was komm raus wenn es durch 3 und 5 teilbar ist 
            {
                if (zahl % i == 0)
                {
                    if (i == 3)
                    {
                        ergebniss += "FIZZ";
                    }
                    if (i == 5)
                    {
                        ergebniss += "BUZZ";
                    }
                }
            }

            if (ergebniss == "")
            {
                Console.WriteLine(zahl);
            }
            else
            {
                Console.WriteLine(ergebniss);
            }

        }
    }
}
Console.WriteLine("\nMöchten Sie wider versuchen?");
Console.WriteLine("Wenn ja [1]");
Console.WriteLine("Wenn nein [2]");
char antwort3 = Convert.ToChar(Console.ReadLine());
if (antwort3 == '1')
{
    Console.Clear();
    Console.WriteLine("Bitte geben Sie Ihre Zahl ein:");
    int fb = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    Console.WriteLine("Zahlen bis zu" + fb + ": ");
    for (int zahl = 0; zahl <= fb; zahl++) //zahlen gehen bis zu diese zahl 
    {
        string ergebniss = "";

        for (int i = 3; i <= 5; i += 2) //was komm raus wenn es durch 3 und 5 teilbar ist 
        {
            if (zahl % i == 0)
            {
                if (i == 3)
                {
                    ergebniss += "FIZZ";
                }
                if (i == 5)
                {
                    ergebniss += "BUZZ"; 
                }
            }
        }

        if (ergebniss == "")
        {
            Console.WriteLine(zahl);
        }
        else
        {
            Console.WriteLine(ergebniss);
        }

    }
}
else
{
    Console.Clear();
    Console.WriteLine("Tschüss!");
}


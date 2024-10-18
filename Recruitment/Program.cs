Console.WriteLine("Hej och välkommen, nedan har du lista med alla som kan rekryteras");
List<string> names = ["Adam", "Janan", "Imad", "Saymmon", "Kerem"];
List<String> RNames = [];
bool areDone = false;
while (true)
{
    Console.WriteLine("Names:");
    for (int i = 0; i < names.Count; i++)
    {
        Console.WriteLine($"{i + 1}" + names[i]);
    }

    Console.WriteLine("\nRecruits:");
    for (int i = 0; i < RNames.Count; i++)
    {
        Console.WriteLine($"{i + 1}. " + RNames[i]);
    }
    int intAnswer = 0;
    bool parseCorrect = false;
    string answer = "";

    while (!parseCorrect)
    {
        if (RNames.Count != 3)
        {
            Console.WriteLine("Choose a person to recruit by number");
            answer = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("You are done, you recruited 3 employers \n");
            areDone = true;
            break;
        }
        parseCorrect = int.TryParse(answer, out intAnswer);
        if (!parseCorrect || intAnswer <= 0 || intAnswer > names.Count)
        {
            Console.WriteLine("Type in a valid number");
            parseCorrect = false;
        }
    }

    if (!areDone)
    {
        RNames.Add(names[intAnswer - 1]);
        names.RemoveAt(intAnswer - 1);
    }


    if (areDone)
    {
        break;
    }
}
Console.ReadLine();

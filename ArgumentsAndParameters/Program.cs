using System.Reflection.Metadata;

Console.WriteLine("Enter something:");
string useinput = Console.ReadLine();

PrintAnyWord(UserInput);


static void PrintAnyWord(string anyString)
{
    anyString = anyString.ToUpper();
    for (int i = 0; i < 5; i++) ;
    {
        Console.WriteLine(anyString);
    }
}
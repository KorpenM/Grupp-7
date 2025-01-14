using System.Reflection.Metadata;

internal class Personnummer
{
    public string AddSeccurityNumber(string secNumb)
    {
        Console.Write("Please type in your security nymber...");
        secNumb = Console.ReadLine();
        
        int counter = secNumb.Length;
        Console.WriteLine(counter);
        
        string birthDate = secNumb.Substring(0, 6);
        string birthNumb = secNumb.Substring(6, 4);

        secNumb = birthDate + "-" + birthNumb;

        Console.WriteLine("Your security number is " + secNumb);

        return secNumb;
    }
}
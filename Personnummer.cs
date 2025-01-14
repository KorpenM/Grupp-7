public class Personnummer
{
    public string AddSecurityNumber(string secNumb)
    {
        Console.Write("Please type in your security number...");
        secNumb = Console.ReadLine();

        return secNumb;
    }

    public int CheckSecurityNumber(string secNumb)
    {
        int count = secNumb.Length;

        return count;
    }

    public string FormatSecurityNumber(string secNumb)
    {
        string yy = secNumb.Substring(0, 2);
        string mm = secNumb.Substring(2, 2);
        string dd = secNumb.Substring(4, 2);
        string xxxx = secNumb.Substring(6, 4);

        string formattedSecNumber = $"{yy}{mm}{dd}-{xxxx} ";
    
        return formattedSecNumber;
    }
}
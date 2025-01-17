using System.Collections.Generic;
/******************************************************* 
 UI
*******************************************************/

Console.Write("Please type in your security number (YYMMDDXXXX): ");
string? secNumb = Console.ReadLine();

Console.Write("Were you born before the year 2000? (Y/N): ");
string answer = Console.ReadLine();
string answerLower = answer.ToLower();

if (CheckSecNumber(secNumb, answerLower)!= null)
{
    System.Console.WriteLine(CheckSecNumber(secNumb, answerLower));
}
else 
{
    Console.WriteLine("Value is null/input invalid.");
}

Console.WriteLine("Press any key to exit program...");
Console.ReadKey();


/******************************************************* 
 Logic
*******************************************************/


//Check if the number is correct length (10 characters) and numeric
string? CheckSecNumber(string secNumb, string answerLower)
{
    int counter = secNumb.Length;

    if (counter == 10)
    {        
        string formattedSecNumber = FormatSecNumber(secNumb, answerLower);
        return "Your security number is " + formattedSecNumber;
    }
    else if (secNumb.Length != 10)
    {
        return "Input is not valid";
    }

    return null;
}

//Format the number to yymmdd-xxxx
string FormatSecNumber(string secNumb, string answerLower)
{
    if (secNumb.Length != 10)
    {
        throw new ArgumentException("Input must be 10 characters.");
    }

    string yy = secNumb.Substring(0, 2);
    string mm = secNumb.Substring(2, 2);
    string dd = secNumb.Substring(4, 2);
    string xxxx = secNumb.Substring(6, 4);


    if (!int.TryParse(mm, out int month) || month < 1 || month > 12)
    {
        throw new ArgumentException("Invalid month in security number.");
    }


    int ageCheck = int.Parse(yy);

    if (answerLower == "y" && ageCheck <= 24)
    {
        string formattedSecNumber = $"{yy}{mm}{dd}-{xxxx}";
        return formattedSecNumber;
    }
    else
    {
        string formattedSecNumber = $"{yy}{mm}{dd}-{xxxx}";
        return formattedSecNumber;
    }
}


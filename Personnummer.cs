using System.Collections.Generic;
/******************************************************* 
 UI
*******************************************************/

Console.Write("Please type in your security number...");
string? secNumb = Console.ReadLine();

if (CheckSecNumber(secNumb)!= null)
{
    System.Console.WriteLine(CheckSecNumber(secNumb));
}
else 
{
    Console.WriteLine("Value is null");
}

Console.WriteLine("Press any key to exit program...");
Console.ReadKey();


/******************************************************* 
 Logic
*******************************************************/


//Check if the number is correct length (10 characters)
string? CheckSecNumber(string secNumb)
{
    int counter = secNumb.Length;

    if (counter == 10)
    {
        string formattedSecNumber = FormatSecNumber(secNumb);
        return "Your security number is " + formattedSecNumber;

    }
    else if (secNumb.Length != 10)
    {
        return "Input is not valid";
    }

    return null;
}

//Format the number to yymmdd-xxxx
string FormatSecNumber(string secNumb)
{
    string yy = secNumb.Substring(0, 2);
    string mm = secNumb.Substring(2, 2);
    string dd = secNumb.Substring(4, 2);
    string xxxx = secNumb.Substring(6, 4);

    string formattedSecNumber = $"{yy}{mm}{dd}-{xxxx} ";
    
    return formattedSecNumber;
}


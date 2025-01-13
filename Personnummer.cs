Console.Write("Please type in your security nymber...");
string secNumb = Console.ReadLine();

int counter = secNumb.Length;
Console.WriteLine(counter);

if (counter == 10)
{
    string birthYear = secNumb.Substring(0, 2);
    string birthMonth = secNumb.Substring(2, 2);
    string birthDay = secNumb.Substring(4, 2);
    string birthNumb = secNumb.Substring(6, 4);

    Console.WriteLine("Your security number is " + birthYear + birthMonth + birthDay + "-" + birthNumb);
}
else if (counter != 10)
{
    Console.WriteLine("Invalid input");
}

Console.WriteLine("Press any key to exit program...");
Console.ReadKey();
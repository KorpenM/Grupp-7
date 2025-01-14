using System.Runtime.CompilerServices;
using Xunit;

public class PersonnummerTests
{
    [Fact]
    public void TestCheck()
    {
        //given
        Personnummer per = new();
        string secNumb = "9711138435";
        int expectedResult = 10;

        //when
        int result = per.CheckSecurityNumber(secNumb);

        //then
        Assert.Equal(expectedResult, result);
    }

        [Fact]
    public void FormatCheck()
    {
        //given
        Personnummer per = new();
        string secNumb = "9711138435";
        string expectedResult = "971113-8435";

        //when
        string result = per.FormatSecurityNumber(secNumb);

        //then
        Assert.Equal(expectedResult, result);
    }
}

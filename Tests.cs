using System;
using Xunit;

namespace Grupp_7
{
    public class UnitTest1
    {
        // Test för giltigt personnummer
        [Fact]
        public void TestValidSecNumber()
        {
            // given
            string secNumb = "1234567890";
            string expected = "Your security number is 1234567890-7890 ";

            // when
            string? result = CheckSecNumber(secNumb);

            // then
            Assert.Equal(expected, result);
        }

        // Test för ogiltigt personnummer (för kort längd)
        [Fact]
        public void TestInvalidSecNumberLength()
        {
            // given
            string secNumb = "12345"; // Ett ogiltigt personnummer (för kort)
            string expected = "Input is not valid"; // Förväntad output

            // when
            string? result = CheckSecNumber(secNumb);

            // then
            Assert.Equal(expected, result); // Kontrollerar förväntat resultat
        }

        // Test för null input
        [Fact]
        public void TestNullSecNumber()
        {
            // given
            string? secNumb = null; // Ett ogiltigt personnummer (null input)
            string expected = null;

            // when
            string? result = CheckSecNumber(secNumb);

            // then
            Assert.Null(result); // Kontrollerar resultat null
        }

        // Test för personnummer med icke-numeriska tecken
        [Fact]
        public void TestInvalidSecNumberNonNumeric()
        {
            // given
            string secNumb = "1234abcd90";
            string expected = "Input is not valid";

            // when
            string? result = CheckSecNumber(secNumb);

            // then
            Assert.Equal(expected, result);
        }

        // Test för att kolla om FormatSecNumber gör rätt format
        [Fact]
        public void TestFormatSecNumber()
        {
            // given
            string secNumb = "1234567890"; // Ex på personnummer
            string expected = "1234567890-7890 ";

            // when
            string formattedSecNumber = FormatSecNumber(secNumb);

            // then
            Assert.Equal(expected, formattedSecNumber); // Kontrollerar korrekt format
        }

        // Metoderna som testas i applikationen
        public string? CheckSecNumber(string secNumb)
        {
            if (string.IsNullOrWhiteSpace(secNumb) || secNumb.Length != 10 || !long.TryParse(secNumb, out _))
            {
                return "Input is not valid";
            }

            string formattedSecNumber = FormatSecNumber(secNumb);
            return "Your security number is " + formattedSecNumber;
        }

        public string FormatSecNumber(string secNumb)
        {
            string yy = secNumb.Substring(0, 2);
            string mm = secNumb.Substring(2, 2);
            string dd = secNumb.Substring(4, 2);
            string xxxx = secNumb.Substring(6, 4);

            return $"{yy}{mm}{dd}-{xxxx} ";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ExpressYourself.Test
{
    [TestFixture]
    public class ExpressYourselfTest
    {
        [TestCase("Type: Book,Title: The Count of Monte Cristo,Length: 928 pages", ExpectedResult = "The Count of Monte Cristo")]
        [TestCase("Type: Magazine,Title: People,Length: 50 pages", ExpectedResult = "People")]
        [TestCase("Type: Book,Title: Pride & Prejudice,Length: 272 pages", ExpectedResult = "Pride & Prejudice")]
        [TestCase("Type: DVD,Title: Avatar,Length: 2h 42m", ExpectedResult = "Avatar")]
        public string GetTitle(string str)
        {
            return Parser.GetTitle(str);
        }

        [TestCase("Type: Book,Title: The Count of Monte Cristo,Length: 928 pages", ExpectedResult = "Book")]
        [TestCase("Type: Magazine,Title: People,Length: 50 pages", ExpectedResult = "Magazine")]
        [TestCase("Type: Book,Title: Pride & Prejudice,Length: 272 pages", ExpectedResult = "Book")]
        [TestCase("Type: DVD,Title: Avatar,Length: 2h 42m", ExpectedResult = "DVD")]
        public string GetType(string str)
        {
            return Parser.GetType(str);
        }

        [TestCase("Type: Book,Title: The Count of Monte Cristo,Length: 928 pages", ExpectedResult = "928 pages")]
        [TestCase("Type: Magazine,Title: People,Length: 50 pages", ExpectedResult = "50 pages")]
        [TestCase("Type: Book,Title: Pride & Prejudice,Length: 272 pages", ExpectedResult = "272 pages")]
        [TestCase("Type: DVD,Title: Avatar,Length: 2h 42m", ExpectedResult = "2h 42m")]
        public string GetLength(string str)
        {
            return Parser.GetLength(str);
        }

        [TestCase("Type: Book,Title: The Count of Monte Cristo,Length: 928 pages", ExpectedResult = true)]
        [TestCase("Type: Magazine,Title: People,Length: 50 pages", ExpectedResult = true)]
        [TestCase("Type: Book,Title: Pride & Prejudice,Length: 272 pages", ExpectedResult = true)]
        [TestCase("Type: DVD,Title: Avatar,Length: 2h 42m", ExpectedResult = true)]
        [TestCase("Avatar", ExpectedResult = false)]
        [TestCase("Type: DVD", ExpectedResult = false)]
        [TestCase("Type: DVD Title: Avatar Length: 2h 42m", ExpectedResult = false)]
        public bool IsValidLine(string str)
        {
            return Parser.IsValidLine(str);
        }


    }
}

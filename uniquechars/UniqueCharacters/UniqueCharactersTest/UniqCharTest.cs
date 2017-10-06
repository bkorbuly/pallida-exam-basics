using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using UniqueCharacter;

namespace UniqueCharactersTest
{
    [TestFixture]
    public class UniqCharTest
    {
        [Test]
        public void IsText()
        {
            string input = "bab";
            List<char> output = new List<char>();
            output.Add('a');
            Assert.AreEqual(output, UniqueChar.UniqCharacters(input));
        }
        [Test]
        public void UpercaseLowercaseDifferent()
        {
            string input = "bAB";
            List<char> output = new List<char>();
            output.Add('a');
            Assert.AreEqual(output, UniqueChar.UniqCharacters(input));
        }
        [Test]
        public void IsEmpty()
        {
            string input = "";
            List<char> output = new List<char>();
            Assert.AreEqual(output, UniqueChar.UniqCharacters(input));
        }

    }
}

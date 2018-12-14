using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingAlgorithms.Others
{
    [TestFixture]
    public class PigLatinTest
    {
        [Test]
        public void Run_ShouldReturnNullForNullImput()
        {
            Assert.That(PigLatin.Run(null), Is.Null);
        }

        [Test]
        public void Run_ShouldReturnEmptyStringForEmptyImput()
        {
            Assert.That(PigLatin.Run(""), Is.EqualTo(""));
        }

        [Test]
        public void Run_ShouldReturnPigLatingWord()
        {
            Assert.That(PigLatin.Run("Mark Farragher"), Is.EqualTo("arkmay arragherfay"));
        }
    }
}

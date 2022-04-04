using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }
      
        [Test]
        public void Subtraction_Valid_Schlautman()
        {
            Assert.AreEqual(4, Program.Subtract("5", "1"));
            Assert.AreEqual(4, Program.Subtract("12", "8"));
            Assert.AreEqual(22, Program.Subtract("27", "5"));
        }

        [Test]
        public void Subtraction_Invalid_Schlautman()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "m8"));
            Assert.Throws<FormatException>(() => Program.Subtract("98", "p1"));
            Assert.Throws<FormatException>(() => Program.Subtract("-3", "d"));
        }
        
        
        // Implement 3 tests per operation, following a similar pattern as above
    }
}

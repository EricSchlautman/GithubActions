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
        
        [Test]
        public void Multiply_Valid_Schlautman()
        {
            Assert.AreEqual(24, Program.Multiply("2", "12"));
            Assert.AreEqual(96, Program.Multiply("12", "8"));
            Assert.AreEqual(0, Program.Multiply("4", "0"));
        }

        [Test]
        public void Multiply_Invalid_Schlautman()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("1", "m8"));
            Assert.Throws<FormatException>(() => Program.Multiply("98", "p1"));
            Assert.Throws<FormatException>(() => Program.Multiply("-3", "d"));
        }

        [Test]
        public void Multiply_Null_Schlautman()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("-98", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }
        
        [Test]
        public void Divide_Valid_Schlautman()
        {
            Assert.AreEqual(2, Program.Divide("12", "6"));
            Assert.AreEqual(3, Program.Divide("12", "4"));
            Assert.AreEqual(1, Program.Divide("1", "1"));
        }

        [Test]
        public void Divide_Invalid_Schlautman()
        {
            Assert.Throws<FormatException>(() => Program.Divide("1", "m8"));
            Assert.Throws<FormatException>(() => Program.Divide("98", "p1"));
            Assert.Throws<FormatException>(() => Program.Divide("-3", "d"));
        }

        [Test]
        public void Divide_Null_Schlautman()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("-98", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }
        // Implement 3 tests per operation, following a similar pattern as above
    }
}

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
            var testArray = []
            testArray[0] = "Test";
            
            var testEmail = new Email("");
            testEmail.addEmail("Test");
            Assert.AreEqual(testArray, testEmail.addEmail("Test"));

        }
    }
}

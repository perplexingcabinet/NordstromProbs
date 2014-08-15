using NUnit.Framework;

namespace NordstromProbs.Tests.Unit
{
    [TestFixture]
    public class DupeFinderTests
    {
        private IDupeFinder _objectUnderTest;

        [SetUp]
        public void ConstructTestObject()
        {
            _objectUnderTest = new DupeFinder();
        }

        [Test]
        public void ExampleProblem()
        {
            var intArr = new int[7]{1,5,3,4,2,1,6};
            var dupe = _objectUnderTest.FindDupe(intArr);
            Assert.That(dupe, Is.EqualTo(1));
        }
    }
}

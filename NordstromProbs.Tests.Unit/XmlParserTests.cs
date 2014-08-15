using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace NordstromProbs.Tests.Unit
{
    [TestFixture]
    public class XmlParserTests
    {
        private IXmlParser _objectUnderTest;

        [SetUp]
        public void ConstructTestObject()
        {
            _objectUnderTest = new XmlParser();
        }

        [Test]
        public void ExampleProblem()
        {
            _objectUnderTest.LoadXml(XmlSnippets.ExampleProblemInput);
            var result = _objectUnderTest.FetchAttributesFromRoot("employees", "name");
            var enumerable = result as IList<string> ?? result.ToList();
            Assert.That(enumerable.Count(), Is.EqualTo(2));
            Assert.That(enumerable.Contains("Yuri"));
            Assert.That(enumerable.Contains("Alex"));
        }


    }

    public static class XmlSnippets
    {
        public static string ExampleProblemInput = @"<root><employees><employee><id>1</id><name>Yuri</name></employee><employee><id>2</id><name>Alex</name></employee></employees></root>";
    }
}

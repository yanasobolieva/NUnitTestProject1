using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        private ClassForTests _classForTests;

        [SetUp]
        public void Setup()
        {
            _classForTests = new ClassForTests();
        }

        [Test]
        public void Test1()
        { 
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}
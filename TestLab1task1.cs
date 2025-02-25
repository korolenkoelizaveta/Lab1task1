using Lab1task1;
namespace Testlab1task1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var result = First.Logic.Compare(3, 1, 2);
            CollectionAssert.AreEqual(new int[] { 3, 1, 2 }, result);
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            var result = First.Logic.Compare(-10, 0, 10);
            CollectionAssert.AreEqual(new int[] { 10, -10, 0 }, result);
            Assert.Pass();
        }

        [Test]
        public void Test3()
        {
            int[] result = First.Logic.Compare(4, 1, 1);
            CollectionAssert.AreEqual(new int[] { 4, 1, int.MinValue }, result);
            Assert.Pass();
        }

        [Test]
        public void Test4()
        {
            int[] result = First.Logic.Compare(1, 1, 1);
            CollectionAssert.AreEqual(new int[] { int.MinValue, int.MinValue, int.MinValue }, result);
            Assert.Pass();
        }

    }
}

namespace ProjectWorkers.Test
{
    public class WorkersTests
    {
        [TestCase(new int[3] {10, 20, 30}, 10, 2)]
        public void GetValueTest(int[] sum, int plan, int expected)
        {
            int actual = Workers.GetValue(new int[3] {10, 20, 30}, 10);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
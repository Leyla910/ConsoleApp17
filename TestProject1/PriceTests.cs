namespace ProjectPrice.Tests
{
    public class PriceTests
    {
        [TestCase(new double[5] { 1, 2, 3, 4, 5 }, new double[5] {1.18, 2.36, 3.54, 4.72, 5.8999999999999995})]
        public void GetPriceTest(double[] prices, double [] expected)
        {
            double[] actual = Price.GetPrice(new double[5] { 1, 2, 3, 4, 5 });

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
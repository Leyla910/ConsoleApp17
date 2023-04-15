namespace ProjectPrice
{
    public static class Price
    {
        public static double[] GetPrice(double[] startPrices)
        {
            double[] newPrices = new double[startPrices.Length];

            for (int i = 0; i < startPrices.Length; i++)
            {
                newPrices[i] = startPrices[i] * 1.18d;
                Console.WriteLine(newPrices[i]);
            }
            return newPrices;
        }

        public static void WriteResult()
        {
            Console.WriteLine();
        }
    }
}

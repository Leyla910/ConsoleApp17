namespace ProjectWorkers
{
    public static class Workers
    {
        public static int GetValue(int[] sum, int plan)
        {
            int value = 0;
            for (int i = 0; i < sum.Length; i++)
            {
                if (plan < sum[i])
                {
                    value += 1;
                }
            }
            return value;
        }

        public static void GetResult()
        {
            Console.WriteLine();
        }
    }
}

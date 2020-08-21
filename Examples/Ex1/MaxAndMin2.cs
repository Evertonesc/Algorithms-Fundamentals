namespace Algorithms.Examples.Ex1
{
    public static class MaxAndMin2
    {
        public static int[] MaxAndMin(int[] vector, int max, int min)
        {
            int i;
            int endCicle;
            var n = vector.Length;

            if ((n & 1) > 0)
            {
                vector[n] = vector[n - 1];
                endCicle = n;
            }
            else
            {
                endCicle = n - 1;
            }

            if (vector[0] > vector[1])
            {
                max = vector[0];
                min = vector[1];
            }
            else
            {
                max = vector[1];
                min = vector[0];
            }

            i = 3;
            while (i <= endCicle)
            {
                if (vector[i - 1] > vector[i])
                    if (vector[i - 1] > max)
                        max = vector[i - 1];
                if (vector[i] < min)
                    min = vector[i];
                else
                {
                    if (vector[i - 1] < min)
                        min = vector[i - 1]
                    if (vector[i] > max)
                        max = vector[i];
                }
                i += 2;
            }
            int[] result = new int[] { max, min };
        }
    }
}

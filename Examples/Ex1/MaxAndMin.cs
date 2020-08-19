namespace Algorithms.Examples.Ex1
{
    public static class MaxAndMin
    {
        public static int[] MaxMin(int[] vectorA)
        {
            var Max = vectorA[0];
            var Min = vectorA[0];

            for (int i = 1; i < vectorA.Length; i++)
                if (vectorA[i] > Max)
                    Max = vectorA[i];
                else if (vectorA[i] < Min)
                    Min = vectorA[i];

            int[] result = new int[] { Max, Min };

            return result;
        }
    }
}

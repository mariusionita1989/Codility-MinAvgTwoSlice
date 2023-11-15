using System.Runtime.CompilerServices;

namespace Codility_MinAvgTwoSlice
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 2;
        public const int RANGE_HIGHEST_VALUE = 100000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int[] A)
        {
            int minStartIndex = 0;
            int N = A.Length;

            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE) 
            {
                double minAvg = (A[0] + A[1]) / 2.0;
                for (int i = 2; i < A.Length; i++)
                {
                    double secondAvg = (A[i - 1] + A[i]) / 2.0;
                    double thirdAvg = (A[i - 2] + A[i - 1] + A[i]) / 3.0;

                    if (secondAvg < minAvg)
                    {
                        minAvg = secondAvg;
                        minStartIndex = i - 1;
                    }

                    if (thirdAvg < minAvg)
                    {
                        minAvg = thirdAvg;
                        minStartIndex = i - 2;
                    }
                }
            }
            
            return minStartIndex;
        }
    }
}

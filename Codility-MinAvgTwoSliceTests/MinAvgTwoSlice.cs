using Codility_MinAvgTwoSlice;

namespace Codility_MinAvgTwoSliceTests
{
    public class SolutionTests
    {
        [Fact]
        public void TestExample()
        {
            Solution solution = new Solution();
            int[] A = { 4, 2, 2, 5, 1, 5, 8 };
            int expected = 1;

            int result = solution.solution(A);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestEqualValues()
        {
            Solution solution = new Solution();
            int[] A = { 3, 3, 3, 3, 3, 3, 3 };
            int expected = 0;

            int result = solution.solution(A);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestNegativeValues()
        {
            Solution solution = new Solution();
            int[] A = { -1, -2, -3, -4, -5 };
            int expected = 3;

            int result = solution.solution(A);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestRandomValues()
        {
            Solution solution = new Solution();
            int[] A = { 10, -1, 2, 4, -1, 2, 5 };
            int expected = 1;

            int result = solution.solution(A);

            Assert.Equal(expected, result);
        }
    }
}
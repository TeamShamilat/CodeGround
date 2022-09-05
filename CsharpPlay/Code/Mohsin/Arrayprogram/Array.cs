

namespace CsharpPlay.Code.Mohsin.Arrayprogram
 {
    public class Array
    {
        static public int lent(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }

            int max = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (max < nums[i])
                {
                    max = nums[i];
                }
            }

            return max;
        }


        [Theory]
        [InlineData(new int[] { 3, 5, 6, 330, 5, 33, 12, 6, 3 }, 330)]
        [InlineData(new int[] { 3, 5, 66, 3, 55, 33, 12, 26, 3 }, 66)]
        [InlineData(new int[] { 3, 5, 66, 3, 55, 33, 766, 12, 26, 3 }, 766)]
        [InlineData(new int[] { 3, 5, 66, 3, 55, 33, 1256, 26, 3 }, 1256)]
        public void FindMaxTests(int[] input, int expected)
        {
            int actual = Array.lent(input);
            Assert.Equal(expected, actual);
        }
    }
}















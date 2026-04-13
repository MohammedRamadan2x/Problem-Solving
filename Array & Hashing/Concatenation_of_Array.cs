public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] res = new int[nums.Length * 2];

        for (int i = 0; i < 2; ++i) {
            Array.Copy(nums, 0, res, i * nums.Length, nums.Length);
        }

        return res;
    }
}

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] res = new int[n];
        Array.Fill(res, 1);

        for (int i = 1; i < n; i++) {
            res[i] = res[i - 1] * nums[i - 1];
        }

        int postfix = 1;
        for (int i = n - 1; i >= 0; i--) {
            res[i] *= postfix;
            postfix *= nums[i];
        }
        return res;
    }
}


// Another Solution
// ------------------------

// public class Solution {
//     public int[] ProductExceptSelf(int[] nums) {
//         int n = nums.Length;
//         int[] result = new int[n];
//         int[] prefix = new int[n];
//         int[] suffix = new int[n];

//         prefix[0] = suffix[n - 1] = 1;

//         for (int i = 1; i < n; ++i)
//             prefix[i] = nums[i - 1] * prefix[i - 1];

//         for (int i = n - 2; i >= 0; --i)
//             suffix[i] = nums[i + 1] * suffix[i + 1];

//         for (int i = 0; i < n; ++i)
//             result[i] = prefix[i] * suffix[i];

//         return result;
//     }
// }

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
       
       Dictionary<int, int> indices = new Dictionary<int, int>();

       for(int i = 0; i < nums.Length; ++i) {
           var diff = target - nums[i];
           if (indices.ContainsKey(diff)) {
               return new int[] {indices[diff], i};
           }
           indices[nums[i]] = i;
       }

       return null;
    }
}



// Another Solution
// -----------------------------

// public class Solution {
//     public int[] TwoSum(int[] nums, int target) {
//         // val -> index
//         Dictionary<int, int> indices = new Dictionary<int, int>();

//         for (int i = 0; i < nums.Length; i++) {
//             indices[nums[i]] = i;
//         }

//         for (int i = 0; i < nums.Length; i++) {
//             int diff = target - nums[i];
//             if (indices.ContainsKey(diff) && indices[diff] != i) {
//                 return new int[]{i, indices[diff]};
//             }
//         }

//         return new int[0];
//     }
// }

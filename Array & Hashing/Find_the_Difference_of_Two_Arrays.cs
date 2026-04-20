public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        HashSet<int> numSet1 = new HashSet<int>(nums1);
        HashSet<int> numSet2 = new HashSet<int>(nums2);
        
        List<int> res1 = new List<int>(numSet1);
        res1.RemoveAll(num => numSet2.Contains(num));

        List<int> res2 = new List<int>(numSet2);
        res2.RemoveAll(num => numSet1.Contains(num));

        return new List<IList<int>> { res1, res2 };
    }
}

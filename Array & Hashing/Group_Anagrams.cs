public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        
        var Anagrams = new Dictionary<string, List<string>>();

        foreach (var s in strs) {
            var sortedS = new string(s.OrderBy(c => c).ToArray());

            if (!Anagrams.ContainsKey(sortedS)) 
                Anagrams[sortedS] = new List<string>();

            Anagrams[sortedS].Add(s);
        }

        return Anagrams.Values
            .Select(x => (IList<string>)x)
            .ToList();    
    }
}

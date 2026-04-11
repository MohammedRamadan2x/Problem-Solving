public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        
        var anagrams = new Dictionary<string, List<string>>();

        foreach(var s in strs) 
        {
            int[] count = new int[26];

            foreach(var c in s) 
                count[c - 'a']++;

            string key = string.Join(",", count);

            if(!anagrams.ContainsKey(key)) 
                anagrams[key] = new List<string>();

            anagrams[key].Add(s);
        }

        return anagrams.Values
            .Select(x => (IList<string>)x)
            .ToList();
    }
}



// Another Solution
// --------------------------------



// public class Solution {
//     public IList<IList<string>> GroupAnagrams(string[] strs) {
        
//         var Anagrams = new Dictionary<string, List<string>>();

//         foreach (var s in strs) {
//             var sortedS = new string(s.OrderBy(c => c).ToArray());

//             if (!Anagrams.ContainsKey(sortedS)) 
//                 Anagrams[sortedS] = new List<string>();

//             Anagrams[sortedS].Add(s);
//         }

//         return Anagrams.Values
//             .Select(x => (IList<string>)x)
//             .ToList();    
//     }
// }

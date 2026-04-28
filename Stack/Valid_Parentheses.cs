public class Solution {
    public bool IsPair(char open, char close) {
        if      (open == '(' && close == ')') return true;
        else if (open == '[' && close == ']') return true;
        else if (open == '{' && close == '}') return true;
        else return false;
    }

    public bool IsValid(string s) {
        var openBrackets = new Stack<char>();
        for (int i = 0; i < s.Length; ++i) {
            if (s[i] == '(' || s[i] == '[' || s[i] == '{') 
                openBrackets.Push(s[i]);
            else {
                if (openBrackets.Count == 0) return false;
                if (!IsPair(openBrackets.Peek(), s[i])) return false;
                openBrackets.Pop();
            }
        }

        return openBrackets.Count == 0;
    }
}

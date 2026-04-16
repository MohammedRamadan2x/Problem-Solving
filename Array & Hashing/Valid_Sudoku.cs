public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];

        for (int i = 0; i < 9; ++i) {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for (int r = 0; r < 9; ++r) {
            for (int c = 0; c < 9; ++c) {
                char val = board[r][c];
                if (val == '.') continue;

                int boxIndex = (r/3) * 3 + (c/3);

                if ((rows[r].Contains(val) || cols[c].Contains(val) || boxes[boxIndex].Contains(val))) return false;

                rows[r].Add(val);
                cols[c].Add(val);
                boxes[boxIndex].Add(val);
            }
        }

        return true;
    }
}






// Another Solution
// ----------------------------------

// public class Solution {
//     public bool IsValidSudoku(char[][] board) {
//         Dictionary<int, HashSet<char>> rows = new Dictionary<int, HashSet<char>>();
//         Dictionary<int, HashSet<char>> cols = new Dictionary<int, HashSet<char>>();
//         Dictionary<int, HashSet<char>> squares = new Dictionary<int, HashSet<char>>();

//         for (int i = 0; i < 9; ++i) {
//             rows[i] = new HashSet<char>();
//             cols[i] = new HashSet<char>();
//             squares[i] = new HashSet<char>();
//         }

//         for (int r = 0; r < 9; ++r) {
//             for (int c = 0; c < 9; ++c) {
//                 char val = board[r][c];
//                 if (val == '.') continue;

//                 int squareKey = (r/3) * 3 + (c/3);

//                 if ((rows[r].Contains(val)) || 
//                     (cols[c].Contains(val)) || 
//                     (squares[squareKey].Contains(val))) return false;

//                 rows[r].Add(val);
//                 cols[c].Add(val);
//                 squares[squareKey].Add(val);
//             }
//         }

//         return true;
//     }
// }

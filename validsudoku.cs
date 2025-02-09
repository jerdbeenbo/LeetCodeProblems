public class Solution {
    public bool IsValidSudoku(char[][] board) {

        
        //check if the row is valid
        for(int r = 0; r < board.Length; r++) {

            //total number of duplicates
            int current_duplicate = 0;

            //loop through the row and make sure there is no repetition
            for (int i = 0; i < board[r].Length; i++) {
                char current = board[r][i];

                int count = 0;

                //each actual populated value needs to have only occured once
                for (int x = 0; x < board[r].Length; x++) { // -> O(n3) (cubic time)

                    if(current == '.') {
                        break;
                    }
                    else if((current == board[r][x]) && (i != x)) { //doesn't check its own position or unfilled position
                        
                        count++;

                        //don't check current anymore if its already a duplicate
                        if (count > 0) {
                            current_duplicate++;
                            break;
                        }
                    }
                }

            }

            //end it early if the first rule is violated
            if (current_duplicate > 0) {
                return false;
            }
        }

        //check if the column is valid
        for(int c = 0; c < board.Length; c++) {

            //total number of duplicates
            int current_duplicate = 0;

            //loop through the column and make sure there is no repetition
            for (int i = 0; i < board[c].Length; i++) {
                char current = board[i][c];

                //Console.WriteLine(current);

                
                int count = 0;

                //each actual populated value needs to have only occured once
                for (int x = 0; x < board[c].Length; x++) { // -> O(n3) (cubic time)

                    if(current == '.') {
                        break;
                    }
                    else if((current == board[x][c]) && (i != x)) { //doesn't check its own position or unfilled position
                        
                        count++;

                        //don't check current anymore if its already a duplicate
                        if (count > 0) {
                            current_duplicate++;
                            break;
                        }
                    }
                }

            }

            //end it early if the first rule is violated
            if (current_duplicate > 0) {
                return false;
            }

        }

        //check if sub squares contain digits 1-9
        /*
        [["8","3",".",".","7",".",".",".","."],
        ["6",".",".","1","9","5",".",".","."],
        [".","9","8",".",".",".",".","6","."],
        ["8",".",".",".","6",".",".",".","3"],
        ["4",".",".","8",".","3",".",".","1"],
        ["7",".",".",".","2",".",".",".","6"],
        [".","6",".",".",".",".","2","8","."],
        [".",".",".","4","1","9",".",".","5"],
        [".",".",".",".","8",".",".","7","9"]]
        */
        // ->
        /*
        [["8","3","."]
        ["6",".","."]
        [".","9","8"]
        ["8",".","."]
        ["4",".","."]
        ["7",".","."]
        [".","6","."]
        [".",".","."]
        [".",".","."]]
        */

        //9 subgrids total
        for (int s = 0; s < 9; s++) {  

            int count = 0;

            List<char> used_char = new List<char>{};

            switch (s) {
                case 0:
                    for (int c = 0; c < 3; c++) {
                        for (int i = 0; i < 3; i++) {

                            char current = board[i][c];

                            if(current != '.') {
                                used_char.Add(current);
                            }
                        }
                    }
                    for (int r = 0; r < 3; r++) {
                        for (int i = 0; i < 3; i++) {

                            char current = board[r][i];
                            if(current != '.') {
                                used_char.Add(current);
                            }
                        }
                    }
                    break;
                case 1:
                    for (int c = 0; c < 3; c++) {
                        for (int i = 0; i < 3; i++) {

                            char current = board[i][c + 3];
                            if(current != '.') {
                                used_char.Add(current);
                            }
                        }
                    }
                    for (int r = 0; r < 3; r++) {
                        for (int i = 0; i < 3; i++) {

                            char current = board[r][i + 3];
                            if(current != '.') {
                                used_char.Add(current);
                            }
                        }
                    }
                    break;
                case 2:
                    for (int c = 0; c < 3; c++) {
                        for (int i = 0; i < 3; i++) {

                            char current = board[i][c + 6];
                            if(current != '.') {
                                used_char.Add(current);
                            }
                        }
                    }
                    for (int r = 0; r < 3; r++) {
                        for (int i = 0; i < 3; i++) {

                            char current = board[r][i + 6];
                            if(current != '.') {
                                used_char.Add(current);
                            }
                        }
                    }
                    break;
                case 3:
                    for (int c = 0; c < 3; c++) {
                        for (int i = 0; i < 3; i++) {

                            char current = board[i + 3][c];
                            if(current != '.') {
                                used_char.Add(current);
                            }
                        }
                    }
                    for (int r = 0; r < 3; r++) {
                        for (int i = 0; i < 3; i++) {

                            char current = board[r + 3][i];
                            if(current != '.') {
                                used_char.Add(current);
                            }
                        }
                    }
                    break;
                case 4:
                    for (int c = 0; c < 3; c++) {
                        for (int i = 0; i < 3; i++) {

                            char current = board[i + 3][c + 3];
                            if(current != '.') {
                                used_char.Add(current);
                            }
                        }
                    }
                    for (int r = 0; r < 3; r++) {
                        for (int i = 0; i < 3; i++) {

                            char current = board[r + 3][i + 3];
                            if(current != '.') {
                                used_char.Add(current);
                            }
                        }
                    }
                    break;
                case 5:
                    for (int c = 0; c < 3; c++) {
                        for (int i = 0; i < 3; i++) {

                            char current = board[i + 6][c + 3];
                            if(current != '.') {
                                used_char.Add(current);
                            }
                        }
                    }
                    for (int r = 0; r < 3; r++) {
                        for (int i = 0; i < 3; i++) {

                            char current = board[r + 6][i + 3];
                            if(current != '.') {
                                used_char.Add(current);
                            }
                        }
                    }
                    break;
                case 6:
                    for (int c = 0; c < 3; c++) {
                        for (int i = 0; i < 3; i++) {

                            char current = board[i + 6][c];
                            if(current != '.') {
                                used_char.Add(current);
                            }
                        }
                    }
                    for (int r = 0; r < 3; r++) {
                        for (int i = 0; i < 3; i++) {

                            char current = board[r + 6][i];
                            if(current != '.') {
                                used_char.Add(current);
                            }
                        }
                    }
                    break;
                case 7:
                    for (int c = 0; c < 3; c++) {
                        for (int i = 0; i < 3; i++) {

                            char current = board[i + 3][c + 6];
                            if(current != '.') {
                                used_char.Add(current);
                            }
                        }
                    }
                    for (int r = 0; r < 3; r++) {
                        for (int i = 0; i < 3; i++) {

                            char current = board[r + 3][i + 6];
                            if(current != '.') {
                                used_char.Add(current);
                            }
                        }
                    }
                    break;
                case 8:
                    for (int c = 0; c < 3; c++) {
                        for (int i = 0; i < 3; i++) {

                            char current = board[i + 6][c + 6];
                            if(current != '.') {
                                used_char.Add(current);
                            }
                        }
                    }
                    //check the same numbers but this time check against stored for duplicates
                    for (int r = 0; r < 3; r++) {
                        for (int i = 0; i < 3; i++) {

                            char current = board[r + 6][i + 6];
                            if(current != '.') {
                                used_char.Add(current);
                            }
                        }
                    }
                    break;
            }

            foreach (char c in used_char) {
                Console.WriteLine("value: " + c);
                int count_ = used_char.Where(x => x.Equals(c)).Count();
                Console.WriteLine("This value appears " + count_ + " times.");

                if (count_ > 2) {
                    return false;
                }
            }

        }

        //if the program gets here, no issues found
        return true;

        /*
        [[".",".",".",".","5",".",".","1","."],
        [".","4",".","3",".",".",".",".","."],
        [".",".",".",".",".","3",".",".","1"],

        ["8",".",".",".",".",".",".","2","."],
        [".",".","2",".","7",".",".",".","."],
        [".","1","5",".",".",".",".",".","."],

        [".",".",".",".",".","2",".",".","."],
        [".","2",".","9",".",".",".",".","."],
        [".",".","4",".",".",".",".",".","."]]
        */

    }
}
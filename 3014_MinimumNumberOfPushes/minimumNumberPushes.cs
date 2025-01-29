public class Solution {
    public int MinimumPushes(string word) {
        
        //map keyboard functionality with a 2d array
        string[,] map = new string[3,3];

        int index = 0;
        bool mapping = true;

        int stackAmount = 0;

        //populate the map
        if(mapping) {
            for (int row = 0; row < map.GetLength(0); row++) {
                for(int col = 0; col < map.GetLength(1); col++) {
                    //loop over the word starting at key 2 (key 1 is always empty)
                    //Console.WriteLine(index);
                    if(index >= word.Length) {
                        //check if the word has been explored fully

                        //populate the rest of the array with just spaces
                        map[row,col] = "";
                        //mapping = false;
                    }
                    else {
                        //do nothing for 0,0
                        if(row == 0 && col == 0) {
                            map[row,col] = "";  // Initialize with empty string
                        }
                        else {
                            //if the word is smaller than 3x3 grid
                            if(word.Length < 8) {
                                map[row,col] += word[index];
                                index = index + 1;
                            }
                            else {

                                //if the word length is higher than 24 we need to quadruple up
                                if(word.Length > 24) {
                                    //find difference
                                    int difference = word.Length - 24;
                                    
                                    //difference is the amount of buttons that have to double up
                                    if(stackAmount >= difference) {
                                        //triple up
                                        for (int i = 0; i < 3; i++) {
                                            map[row,col] += word[index];
                                            index = index + 1;
                                        }
                                    }
                                    else {
                                        //quadruple up
                                        for (int i = 0; i < 4; i++) {
                                            map[row,col] += word[index];
                                            index = index + 1;
                                        }
                                        stackAmount++;
                                    }
                                }

                                //16
                                //if the word length is higher than 16 we need to triple up
                                else if(word.Length > 16) {
                                    //find difference
                                    int difference = word.Length - 16;
                                    
                                    //difference is the amount of buttons that have to double up
                                    if(stackAmount >= difference) {
                                        //double up
                                        for (int i = 0; i < 2; i++) {
                                            map[row,col] += word[index];
                                            index = index + 1;
                                        }
                                    }
                                    else {
                                        //triple up
                                        for (int i = 0; i < 3; i++) {
                                            map[row,col] += word[index];
                                            index = index + 1;
                                        }
                                        stackAmount++;
                                    }
                                }
                                else {
                                    //find difference
                                    int difference = word.Length - 8;

                                    //difference is the amount of buttons that have to double up
                                    if(stackAmount >= difference) {
                                        map[row,col] += word[index];
                                        index = index + 1;
                                    }
                                    else {
                                        //double up
                                        for (int i = 0; i < 2; i++) {
                                            map[row,col] += word[index];
                                            index = index + 1;
                                        }
                                        stackAmount++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        
        foreach(string s in map) {
            Console.Write(s + ", ");
        }
        
        
        
        int presses = 0;

        //loop over the word provided
        for (int i = 0; i < word.Length; i++) {
            //check what position the char is at
            foreach(string button in map) {
                if(button.Contains(word[i])) {
                    //current char is at this position on keyboard

                    //check where it is in the press queue
                    if(button != null && button.Length > 0 && button[0] == word[i]) {

                        presses = presses + 1;
                    }
                    else if(button != null && button.Length > 0 && button[1] == word[i]) {
                        //check character preceeding on button isn't char preceeding in word
                        presses = presses + 2;
                    }
                    else if(button != null && button.Length > 0 && button[2] == word[i]) {   
                        //check character preceeding on button isn't char preceeding in word
                        presses = presses + 3;
                    }
                    else if(button != null && button.Length > 0 && button[3] == word[i]) {   
                        //check character preceeding on button isn't char preceeding in word
                        presses = presses + 4;
                    }
                }
            }
        }

    
        
        return presses;
    }
}
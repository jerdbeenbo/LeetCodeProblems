public class Solution {
    public int LengthOfLastWord(string s) {
        string word = "";
        for(int i = s.Length - 1; i != 0 - 1; i--) { //loop down to zero starting at the end of the string length or until broken out of loop
            //Console.WriteLine(i);
            //check if current pos is a space
            if (s[i] == ' ') {
                //if word is still empty, find start of the word
                if(word == "") {
                    //keep iterating until we find start of word
                    continue;
                }
                //if word is not empty, determine that the space means the word is complete
                else if(word != "") {
                    break;
                }
            }
            else {
                word = word + s[i];
            }
        }
        Console.WriteLine(word);
        int result = word.Length;
        return result;
    }
}
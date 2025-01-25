public class Solution {
    public bool IsCircularSentence(string sentence) {
        //first check position [0] and position [n]
        if(sentence[0] == sentence[sentence.Length - 1]) {
            //second rule passed:
            //The last character of the last word is equal to the first character of the first word.

            //now check if index at positions before and after a space is equal to each other
            //loop over sentence
            for(int i = 0; i < sentence.Length; i++) {
                //check if pos is a space
                if(sentence[i] == ' ') {
                    //check i-1 and i+1 equal
                    if(sentence[i-1] == sentence[i+1]) {
                        //don't have to any further logic, the code should fall into the correct return statement if this if check
                        //fails, otherwise it'll leave the for loop and return true
                    }
                    else {
                        return false;
                    }
                }
            }
            return true;
        }
        else {
            Console.WriteLine("Ends did not match");
            return false;
        }
    }
}
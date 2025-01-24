public class Solution {
    public bool DetectCapitalUse(string word) {

        int captialAmount = 0;
        bool capitalFirst = false;
        
        //loop over string and and check if word follows uppercase constraints
        for(int i = 0; i < word.Length; i++) {
            if(Char.IsUpper(word[i])) {
                //check current pos and increment if a capital is found
                captialAmount++;

                //check if at first index position
                if(i == 0) {
                    capitalFirst = true;
                }
            }
        }

        //check rules
        if((captialAmount == word.Length) || ((capitalFirst == true) && (captialAmount == 1) || (captialAmount == 0))) {
            //whole word is captialised or only first letter is capitalised or there are no capitals
            return true;
        }
        else if (captialAmount > 1){
            //has more than 1 captial
            return false;
        }
        else {
            return false;
        }
    }
}
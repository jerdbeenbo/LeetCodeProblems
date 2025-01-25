public class Solution {
    public string GenerateTheString(int n) {
        //generate a string that is equal to the size of n

        //create return string
        string returnString = "";

        if(n % 2 == 0) {
            //string is even

            for(int i = 0; i < n - 1; i++) {
                returnString = returnString + "a";
            }

            returnString = returnString + "b";
        }
        else {
            for(int i = 0; i < n; i++) {
                returnString = returnString + "a";
            }           
        }

        return returnString;
    }
}
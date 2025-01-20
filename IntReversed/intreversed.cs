public class Solution {
    public int Reverse(int x) {
        //convert the integar to a string

        string intString = x.ToString();
        string reversed = "";

        //loop over the string and reverse it
        for (int i = intString.Length - 1; i >= 0; i--) {
            reversed = reversed + intString[i];
        }

        //move the sign
        if(reversed[reversed.Length - 1] == '-') {
            string temp = "";
            //alter the string
            for (int i = 0; i < reversed.Length - 1; i++) {
                //Console.WriteLine(temp);
                temp = temp + reversed[i];
            }
            reversed = temp;
            reversed = "-" + reversed;
        }

        Console.WriteLine(reversed);
        
        
        //convert string back to int
        reversed = reversed.Trim();

        int number;
        
        bool success = Int32.TryParse(reversed, out number);
        if (success) {
            return number;
        }
        else {
            return 0;
        }
        //int return_ = Int32.Parse(reversed);

        //check that the int doesn't exceed the range
        //if()
    }
}
public class Solution {
    public int CountOdds(int low, int high) {

        int oddAmount = 0;

        if(low % 2 != 0) {
            //number is an odd, every second number after current is odd (include starting position)
            oddAmount = ((oddAmount + 1) + (high - (low+1)) / 2);

            //count high number if it is odd
            if(high % 2 !=0) {
                oddAmount++;
            }

            Console.WriteLine(oddAmount);
        }
        else {
            //starting number is even (dont include current pos)
            oddAmount = (oddAmount + (high - low) / 2);

            //count high number if it is odd
            if(high % 2 !=0) {
                oddAmount++;
            }

            Console.WriteLine(oddAmount);
        }

        if((low == high) && (low % 2 != 0)) {
            return 1;
        }
        else if ((low == high) && (low % 2 == 0)){
            return 0;
        }

        return oddAmount;
    }
}
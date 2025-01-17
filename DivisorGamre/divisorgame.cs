public class Solution {
    public bool DivisorGame(int n) {
        //n is the number on the chalkboard

        //check if n=1 which is invalid and just return false
        if (n == 1) {
            return false;
        }

        // n / x needs to be a clean division (n % x == 0)
        int i = 1; //odd is alice, even is bob
        bool hasToEnd = false;
        int gameLength = n;
        //loop through each round until a winner is chosen
        for(int j = 0; j < gameLength; j++) {
            Console.WriteLine("\n\n\nRound iteration is: " + j + 1 + " and should iterate for: " + gameLength);
            if(hasToEnd == false) {
                //alice always starts first
                //pick num
                int numberPicked;
                for(int x = 0; x <= n; x++) {
                    //Console.WriteLine("Trying to find number pick, current choice: " + x);
                    //x will be the number
                    if ((x > 0 && x < n) && (n % x == 0)) {
                        numberPicked = x;
                        Console.WriteLine("Number picked: " + numberPicked + ". Round player is: " + i);

                        //replace n on chalkboard if picked
                        n = n - x;
                        Console.WriteLine("New n: " + n);
                        break;
                    }
                    else if (x < n) { //there are still numbers to find
                        //player did not find a number to pick but still more options
                        Console.WriteLine("Round player is: " + i + ". " + x + " is not a valid number but not ending");
                        //hasToEnd = true;
                    }
                    else {
                        //player cannot play a round, game over
                        Console.WriteLine("Round player is: " + i + ". Cannot pick a number");
                        Console.WriteLine("Ended the game on player: " + i);
                        hasToEnd = true;
                    }
                }

                i++; //iterate which player is playing the round (odd is alice, even is bob)
            }
        }

        if(i % 2 == 0) {
            //number is even and the game ended during bob's turn, alice won
            return false;
        }
        else {
            //number is odd and the game ended during alice's, bob won
            return true;
        }
    }
}
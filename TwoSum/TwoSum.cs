public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        //instantiate array of indicies to return
        int[] indicies = new int[2];

        bool solutionFound = false;

        //loop through array (outerloop) and check position [n] against other positions, if no solution found continue [n+1]
        if(solutionFound == false) {
            for (int i = 0; i < nums.Length; i++) {
                for (int j = 1; j < nums.Length; j++) {
                    if(nums[i] + nums[j] == target) {
                        //Console.WriteLine("We're currently at index " + i + " and index " + j + " of values " + nums[i] + " " + nums[j]);
                        //solution is found, break out of loop
                        if (i == j) {
                            //same iteration and this is not allowed continue
                        }
                        else {
                            indicies = [i, j];
                            return indicies;
                            solutionFound = true;
                        }
                    }
                }
            }
        }
        return indicies;
    }
}
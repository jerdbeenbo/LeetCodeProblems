public class Solution {
    public int DiagonalSum(int[][] mat) {

        /*
            [7,3,1,9]
            [3,4,6,9]
            [6,9,6,6]
            [9,5,8,5]
        */
        
        //find size of matrix
        int size = mat.GetLength(0);
        //Console.WriteLine(size);

        int currentSum = 0;

        //loop for both primary and secondary diagonal diagonal
        for (int i = 0; i < size; i++) {

            //primary
            currentSum = currentSum + mat[i][i];
            //secondary
            currentSum = currentSum + mat[(size - 1) - i][i];

            Console.WriteLine("Primary: " + mat[i][i] + ". Secondary: " + mat[(size - 1) - i][i]);
        }

        //remove middle intersection if needed
        if(size % 2 != 0) { //middle intersects
            Console.WriteLine("intersected");
            currentSum = currentSum - mat[size / 2][size / 2]; //remove the middle by deviding by 2, int will round down
        }

        return currentSum;

    }
}
/*
 * @lc app=leetcode id=704 lang=c
 *
 * [704] Binary Search
 */

// @lc code=start
int search(int* nums, int numsSize, int target) {
    
    //set initial values
    int low = 0;
    int high = numsSize - 1;
    int mid = (low + high) / 2;
    int guess = nums[mid];

    //loop until value found or constraints met
    while (low <= high) {
        mid = (low + high) / 2;
        guess = nums[mid];

        if(guess == target) {
            return mid;
        }
        else if (guess > target) {
            high = mid - 1;
        }
        else {
            low = mid + 1;
        }
    }

    //will only return -1 if target not found
    return -1;

}
// @lc code=end


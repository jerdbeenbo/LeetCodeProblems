/*
 * @lc app=leetcode id=35 lang=c
 *
 * [35] Search Insert Position
 */

// @lc code=start
int searchInsert(int* nums, int numsSize, int target) {
    
    //handle special cases
    if (target > nums[numsSize - 1]) {
        return numsSize;
    }
    if (target < nums[0]) {
        return 0;
    }

    //perform binary search
    int low = 0;
    int high = numsSize - 1;

    int mid = (low + high) / 2;
    int guess = nums[mid];

    while (low <= high) {
        mid = (low + high) / 2;
        guess = nums[mid];

        if(guess == target) {
            return mid;
        }
        else if(guess > target) {
            high = mid - 1;
        }
        else {
            low = mid + 1;
        }
    }

    //if we get to this part in code, target is not in array
    for (int i = 0; i < numsSize; i++) {
        //loop through the array until it is not longer larger than its neighbour
        if(target > nums[i]) {
            continue;
        }
        else {
            printf("Finishing here?");
            return i;
        }
    }

    //shouldn't reach here due to constraints
    return -1;
}
// @lc code=end


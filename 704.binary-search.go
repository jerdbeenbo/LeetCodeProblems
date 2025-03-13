/*
 * @lc app=leetcode id=704 lang=golang
 *
 * [704] Binary Search
 */

// @lc code=start
func search(nums []int, target int) int {
    
    low := 0
    high := len(nums) - 1

	for(low <= high) {

		middle := (low + high) / 2;
		guess := nums[middle];

		if guess > target {
			high = middle - 1;
		} else if guess < target {
			low = middle + 1;
		} else {
			return middle;
		}
	}

	//shouldn't reach here
	return -1;
}
}
// @lc code=end


/*
 * @lc app=leetcode id=35 lang=rust
 *
 * [35] Search Insert Position
 */

// @lc code=start
impl Solution {
    pub fn search_insert(nums: Vec<i32>, target: i32) -> i32 {

        // Special case: if target is greater than the largest element
        if target > nums[nums.len() - 1] {
            return nums.len() as i32;
        }
                
        // Special case: if target is less than the smallest element
        if target < nums[0] {
            return 0;
        }

        if nums.contains(&target) {
            let mut low: usize = 0;
            let mut high: usize = (nums.len() as usize) - 1;
    
            let mut mid: usize = (low + high) / 2;
            let mut guess: i32 = nums[mid];
    
            //loop through and find if it exists in list
            while low <= high {
    
                mid = (low + high) / 2;
                guess = nums[mid];
    
                if guess == target {
                    return mid as i32;
                }
                else if guess > target {
                    high = mid - 1;
                }
                else {
                    low = mid + 1;
                }
            }
        }
        else {
            //check if value will be the biggest
            if target > nums[nums.len() - 1] {
                return nums.len() as i32;
            }

            //if we get to here, doesn't exist, return index of its insert position
            for i in 0..nums.len() {
                //loop value numerically smaller than to its right
                if target > nums[i] {
                    continue;
                }
                else {
                    return i as i32;
                }
            }
        }

        //shouldn't get here due to constraints
        return -1;
    }
}
// @lc code=end


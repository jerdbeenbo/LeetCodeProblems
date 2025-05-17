/*
 * @lc app=leetcode id=75 lang=rust
 *
 * [75] Sort Colors
 */

// @lc code=start
impl Solution {
    pub fn sort_colors(nums: &mut Vec<i32>) {

        if !nums.len() == 1 {
            let mut left: usize = 0;
            let mut right: usize = nums.len() - 1;
            let mut current: usize = 0;

            while current <= right {
                if nums[current] == 0 {
                    nums.swap(current, left);
                    current = current + 1;
                    left = left + 1;
                }
                else if nums[current] == 1 {
                    current = current + 1;
                }
                else {
                    nums.swap(current, right);
                    right = right - 1;
                }
            }
        }

        println!("{:?}", nums);
    }
}
// @lc code=end


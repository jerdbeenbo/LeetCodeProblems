/*
 * @lc app=leetcode id=66 lang=rust
 *
 * [66] Plus One
 */

// @lc code=start
impl Solution {
    pub fn plus_one(digits: Vec<i32>) -> Vec<i32> {
        let mut result = digits.clone(); // Create a mutable copy of the input vector
        
        // Start from the rightmost digit
        for i in (0..result.len()).rev() {
            if result[i] == 9 {
                result[i] = 0;
            } else {
                result[i] += 1;
                return result;
            }
        }
        
        // If we get here, it means all digits were 9
        // We need to add a new digit 1 at the beginning
        result.insert(0, 1);
        result
    }
}
// @lc code=end


/*
 * @lc app=leetcode id=136 lang=rust
 *
 * [136] Single Number
 */

// @lc code=start
use std::collections::HashSet;
impl Solution {
    pub fn single_number(nums: Vec<i32>) -> i32 {
        
        //use a hashset to remove duplicates

        let mut set = HashSet::new();

        let mut rejected: Vec<i32> = Vec::new();

        for i in nums {
            //check if set has item already
            let b: bool = set.insert(i);
            
            //update rejected value
            if b == false {
                rejected.push(i);
            }

            //add to set
            set.insert(i);
        }

        //return value that exists in set that isn't in rejected
        for val in set {
            if rejected.contains(&val) {
                continue;
            }
            else {
                return val;
            }
        }

        //due to constraints will never reach here
        return -1;
    }
}
// @lc code=end


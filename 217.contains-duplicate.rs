/*
 * @lc app=leetcode id=217 lang=rust
 *
 * [217] Contains Duplicate
 */

// @lc code=start

use std::collections::HashSet;

impl Solution {
    pub fn contains_duplicate(nums: Vec<i32>) -> bool {
        
        //use a hashset to guarentee no duplicate values
        //clone nums to hashset
        let mut cd_set: HashSet<i32> = HashSet::from_iter(nums.iter().cloned());

        /*
        //Same thing
        let mut set = HashSet::new();
        for item in nums {
            set.insert(item.clone());
        }
         */

        //compare lengths
        if cd_set.len() != nums.len() {
            return true;
        }
        else {
            return false;
        }

    }
}
// @lc code=end


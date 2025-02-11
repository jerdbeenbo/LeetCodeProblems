/*
 * @lc app=leetcode id=448 lang=rust
 *
 * [448] Find All Numbers Disappeared in an Array
 */

// @lc code=start

use std::collections::HashSet;

impl Solution {

    pub fn find_disappeared_numbers(nums: Vec<i32>) -> Vec<i32> {

        //remove duplicates in the vec
        let nums_set: HashSet<i32> = HashSet::from_iter(nums.iter().cloned());
        let mut nums_return: Vec<i32> = Vec::new();


        let max_value: i32 = find_max(&nums).unwrap();

        //loop over the original checking if i is found in nums_set. if it isn't thats our missing number
        for i in 1..nums.len() + 1 {
            if nums_set.contains(&(i as i32)) {
                continue;
            }
            else {
                nums_return.push(i as i32);
            }
        }


        return nums_return;

    }
}

pub fn find_max(nums: &Vec<i32>) -> Option<i32> {
    //get the max value
    if nums.is_empty() {
        None
    } else {
        Some(*nums.iter().max().unwrap())
    }
}
// @lc code=end


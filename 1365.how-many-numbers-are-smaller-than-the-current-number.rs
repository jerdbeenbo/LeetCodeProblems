/*
 * @lc app=leetcode id=1365 lang=rust
 *
 * [1365] How Many Numbers Are Smaller Than the Current Number
 */

// @lc code=start

use std::collections::HashMap;

impl Solution {
    pub fn smaller_numbers_than_current(nums: Vec<i32>) -> Vec<i32> {
        
        
         let mut nums_sorted: Vec<i32> = Vec::from_iter(nums.iter().cloned());
         nums_sorted.sort();

        //create dictionary
        let mut map = HashMap::new();

        //populate dictionary
        for i in 0..nums_sorted.len() {
            //skip it if it already exists
            if map.contains_key(&i) {
                println!("we are just skipping");
                continue;
            }
            else {
                println!("inserting {} at index {}", nums[i], i);
                map.insert(i, nums[i]);
            }
        }

        let mut nums_r: Vec<i32> = Vec::new();
        for i in 0..nums.len() {
            let v = map.get(&i);
            //nums_r.push(*v.unwrap());
        }

        return nums_r;


    }
}
// @lc code=end


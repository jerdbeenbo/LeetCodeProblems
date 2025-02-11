/*
 * @lc app=leetcode id=1 lang=rust
 *
 * [1] Two Sum
 */

// @lc code=start

use std::collections::HashMap;

impl Solution {
    pub fn two_sum(nums: Vec<i32>, target: i32) -> Vec<i32> {
        
        //aiming for linear time complexity
        let mut map = HashMap::new(); //dictionary

        //loop over the array once
        for i in 0..nums.len() {
            let value_search: i32 = target - nums[i];
            println!("{}", value_search);
            if map.contains_key(&value_search) {
                println!("Found");
                //found a solution
                let mut r: Vec<i32> = Vec::new();
                r.push(i as i32);
                let r_index = map.get(&value_search);
                r.push(*r_index.unwrap() as i32);
                println!{"{} {} is return", i, r_index.unwrap()};
                return r;
            }
            else {
                //couldn't find solution. add current index and value at index to hashmap
                map.insert(nums[i], i);
            }
        }

        //shouldd't ever reach here due to constraints of the problem
        return nums;
    }
}
// @lc code=end


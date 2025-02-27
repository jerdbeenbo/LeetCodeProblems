/*
 * @lc app=leetcode id=2605 lang=rust
 *
 * [2605] Form Smallest Number From Two Digit Arrays
 */

// @lc code=start
impl Solution {
    pub fn min_number(nums1: Vec<i32>, nums2: Vec<i32>) -> i32 {
        
        let mut nums1_s: Vec<i32> = nums1.clone();
        let mut nums2_s: Vec<i32> = nums2.clone();

        nums1_s.sort();
        nums2_s.sort();
        

        if nums2.contains(&nums1[0]) {
            return nums1[0]
        }
        else if nums1_s[0] < nums2_s[0]{
            //return 1_s[0] first then 2_s[0] concatinated
            let s: String = nums1_s[0].to_string() + &nums2_s[0].to_string();

            return s.parse::<i32>().unwrap();
        }
        else {
            //return 2_s[0] first then 1_s[0] concatinated
            let s: String = nums2_s[0].to_string() + &nums1_s[0].to_string();

            return s.parse::<i32>().unwrap();
        }
    }
}
// @lc code=end


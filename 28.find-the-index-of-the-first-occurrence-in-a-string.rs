/*
 * @lc app=leetcode id=28 lang=rust
 *
 * [28] Find the Index of the First Occurrence in a String
 */

// @lc code=start
impl Solution {
    pub fn str_str(haystack: String, needle: String) -> i32 {
        //create a vector of traversed chars
        let mut s: &str = "";

        let mut index_found: i32 = 0;

        //loop over string
        let mut index: usize = 0;
        for c in haystack.chars() {
            if c as u8 == needle.as_bytes()[index] {
                //build a new string
                s = s + c as &str;

                index_found = index;
            }

            index = index + 1;
        }

        //check if constructed word equals needle string
        if needle == s {
            return index_found - s.len();
        }
        else {
            return - 1;
        }
    }
}
// @lc code=end


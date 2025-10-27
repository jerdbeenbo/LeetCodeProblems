/*
 * @lc app=leetcode id=258 lang=rust
 *
 * [258] Add Digits
 */

// @lc code=start
impl Solution {
    pub fn add_digits(num: i32) -> i32 {

        let mut mutable_num = num;

        loop {
            let num_str = mutable_num.to_string();

            //vec to store the slices of the original value
            let mut num_vec: Vec<i32> = Vec::new();

            //loop over the string
            for _char in num_str.chars() {
                let c: u32 = _char.to_digit(10).unwrap();

                num_vec.push(c as i32);
            }

            let mut total = 0;
            //add them together
            for val in num_vec {
                total = total + val;
            }

            //final check
            if total < 10 {
                //pass
                return total;
            }
            else {
                mutable_num = total;
            }
        }
    }
}
// @lc code=end

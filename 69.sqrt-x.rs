/*
 * @lc app=leetcode id=69 lang=rust
 *
 * [69] Sqrt(x)
 */

// @lc code=start
impl Solution {
    ///Calculates a square root using the Babylonian method
    pub fn my_sqrt(x: i32) -> i32 {

        //use f64 for better floating point precision... 
        let mut approx: f64 = x as f64;
        let mut y: f64 = 1.0;
        let e: f64 = 0.00001; //accuracy level
        while (approx - y > e) {
            approx = (approx + y) / 2.0;
            y = x as f64 / approx;
        }
        return approx.floor() as i32;
    }
}
// @lc code=end


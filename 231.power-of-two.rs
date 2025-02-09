/*
 * @lc app=leetcode id=231 lang=rust
 *
 * [231] Power of Two
 */

// @lc code=start
impl Solution {
    pub fn is_power_of_two(n: i32) -> bool {

        if n == 1 {
            return true;
        }
        if n == 2 {
            return true;
        }

        let nf: f32 = n as f32;

        let sqrt_nf: f32 = nf.sqrt();

        //check if the square root is not a clean decimal
        if sqrt_nf.fract() != 0.0 {

            //println!("Making it into the first if");
            
            //first check the cube root
            let nf_64: f64 = nf as f64;
            let cbrt: f64 = nf_64.cbrt();

            if cbrt.fract() != 0.0 {
                return false;
            }
            else {
                return true;
            }
            
            return false;
        }
        else {

            //make sure its a power of 2 (make sure its even)
            let d: f32 = nf / 2.0;
            if d.fract() != 0.0 {
                return false;
            }
            else {
                return true;
            }
        }
    }
}
// @lc code=end


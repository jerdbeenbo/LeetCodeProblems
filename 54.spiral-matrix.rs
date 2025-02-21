/*
 * @lc app=leetcode id=54 lang=rust
 *
 * [54] Spiral Matrix
 */

// @lc code=start
impl Solution {
    pub fn spiral_order(matrix: Vec<Vec<i32>>) -> Vec<i32> {

        let mut spiral: Vec<i32> = Vec::new();

        //row length
        let row_length = matrix[0].len();
        let c_offset = matrix[0].len() - 1;
        
        //build the first part of the spiral
        for r in 0..row_length() {
            for c in 0..row_length() {
                spiral.push(matrix[r][c]);
        }

        //second part is the last element of the remaining individual vectors



        return spiral;

    }
}
// @lc code=end


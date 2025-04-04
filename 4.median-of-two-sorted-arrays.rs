/*
 * @lc app=leetcode id=4 lang=rust
 *
 * [4] Median of Two Sorted Arrays
 */

// @lc code=start
impl Solution {

    pub fn build_array(starting_array: Vec<i32>, inserting_array: Vec<i32>, index_larger: usize) -> Vec<i32> {

        let mut return_arr = Vec::new();
        //build first part
        for i in 0..index_larger {  //might need to be - 1
            return_arr[i] = starting_array[i];
        }
        //concact second array
        for i in (index_larger + 1)..inserting_array.len() {
            return_arr[i] = inserting_array[i];
        } 

        //continue building the tail
        let continue_index = index_larger + inserting_array.len();
        for i in continue_index..starting_array.len() {
            return_arr[i] = starting_array[i];
        }

        return return_arr;
    }

    pub fn merge_arrays(nums1: Vec<i32>, nums2: Vec<i32>) -> Vec<i32> {
        //Choose which array starts with the smallest value
        if (nums1[0] < nums2[0]) {
            //nums1 starts smaller
            
            let mut index_larger: usize = 0;
            //get loop parameters
            for i in 0..nums1.len() {
                if (nums2[i] > nums1[i]) {
                    index_larger = i;
                    break;              //break when finding to avoid an error thrown
                }
            }
            
            //build array
            for i in 0..nums1.len() {
                return Self::build_array(nums1, nums2, index_larger);
            }
        }
        //nums2 starts smaller
        else {
            let mut index_larger: usize = 0;
            //get loop parameters
            for i in 0..nums2.len() {
                if (nums1[i] > nums2[i]) {
                    index_larger = i;
                    break;              //break when finding to avoid an error thrown
                }
            }
            
            //build array
            for i in 0..nums2.len() {
                return Self::build_array(nums2, nums1, index_larger);
            }
        }
    }

    pub fn find_median_sorted_arrays(nums1: Vec<i32>, nums2: Vec<i32>) -> f64 {
        //Merge arrays
        //  -> Both are already sorted, just need to combine when nums1[x] > nums2[x] or vise versa
        let merged = merge_arrays(&nums1, &nums2);

        //find median
        if (merged.len() % 2 == 1) {
            return merged[merged.len() / 2]
        }
        else {
            return (0.5 * (merged[merged.len() / 2 - 1] + merged[merged.len()] / 2))
        }
    }
}
// @lc code=end


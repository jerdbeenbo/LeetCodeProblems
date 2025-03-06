/*
 * @lc app=leetcode id=121 lang=rust
 *
 * [121] Best Time to Buy and Sell Stock
 */

// @lc code=start
impl Solution {
    pub fn max_profit(prices: Vec<i32>) -> i32 {

        if prices.len() == 1 {
            return 0;
        }

        //loop through list and find lowest and highest following constraints
        let mut low_index: i32 = 0;
        let mut high_index: i32 = 0;

        for i in 0..prices.len() {
            if prices[i] < prices[low_index as usize] {
                low_index = i as i32;
            }
            else {
                continue;
            }
        }
        println!("low index is {} and low actual is {}", low_index, prices[low_index as usize]);

        //find highest after low
        println!("loop starts at {} and goes for {}", low_index, prices.len());
        for i in (low_index as usize)..prices.len() {
            //println!("this is i {} and low {}", i, low_index);
            if i == low_index as usize {
                //set initial high_index
                high_index = i as i32;
                //println!("{}", high_index);
            }

            println!("new potential {} vs current {}", prices[i], prices[high_index as usize]);
            if prices[i] > prices[high_index as usize] {
                high_index = i as i32;
            }
        }

        //check if high index is lower than low_index (solution wasn't found)
        if high_index < low_index {
            return 0;
        }

        println!("this is low {} and this is high {}", low_index, high_index);

        return prices[high_index as usize] - prices[low_index as usize];
    }
}
// @lc code=end


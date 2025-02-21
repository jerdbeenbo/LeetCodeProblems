impl Solution {
    pub fn search(nums: Vec<i32>, target: i32) -> i32 {
        
        let mut low: i32 = 0;
        let mut high: i32 = nums.len() as i32 - 1;

        let mut mid: i32 = (low + high) / 2;
        let mut guess: i32 = nums[mid as usize];

        println!("Low: {} High: {}", low, high);

        while low <= high {
            mid = (low + high) / 2;
            guess = nums[mid as usize];

            println!("{}", guess);

            if guess == target {
                return mid;
            }
            else if guess > target {
                high = mid - 1;
            }
            else {
                low = mid + 1;
            }
        }
        return -1;
    }
}
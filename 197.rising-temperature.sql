--
-- @lc app=leetcode id=197 lang=mysql
--
-- [197] Rising Temperature
--

-- @lc code=start
# Write your MySQL query statement below

SELECT * FROM Weather
WHERE temperature > (
    SELECT temperature FROM Weather w2
    WHERE w2.recordDate = DATE(Weather.recordDate, '-1 day')
)

-- @lc code=end


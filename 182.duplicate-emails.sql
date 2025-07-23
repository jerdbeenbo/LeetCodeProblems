--
-- @lc app=leetcode id=182 lang=mysql
--
-- [182] Duplicate Emails
--

-- @lc code=start
# Write your MySQL query statement below
SELECT p.email
FROM Person p
GROUP BY p.email 
HAVING COUNT(*) > 1;

-- @lc code=end


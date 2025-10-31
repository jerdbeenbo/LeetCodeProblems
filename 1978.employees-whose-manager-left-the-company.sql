--
-- @lc app=leetcode id=1978 lang=mysql
--
-- [1978] Employees Whose Manager Left the Company
--

-- @lc code=start
# Write your MySQL query statement below
select employee_id from Employees
where salary < 30000 and manager_id not in (select employee_id from Employees)
order by employee_id

-- @lc code=end


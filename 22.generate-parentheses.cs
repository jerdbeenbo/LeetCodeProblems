/*
 * @lc app=leetcode id=22 lang=csharp
 *
 * [22] Generate Parentheses
 */

// @lc code=start
public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        
        List<string> return_list = new List<string>{};
        
        string return_string = "";
        int open = 0;
        int closed = 0;

        for(int i = 0; i < n*2; i++) {

            Console.WriteLine("Current iteration: " + i);

            //add an open parentheses or closed parentheses
            if(i < n && open <= closed) {
                Console.WriteLine("Adding open parentheses");
                return_string += "(";
                //keep track of open parentheses
                open++;
            }
            else if(closed < open) {
                Console.WriteLine("Adding closed parentheses");
                return_string += ")";
                closed++;
            }
        }

        Console.WriteLine(return_string);

        return return_list;
    }
}
// @lc code=end


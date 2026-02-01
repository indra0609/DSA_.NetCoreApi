namespace DSA.Stack
{
    public class EasyStack
    {
        #region valid-parentheses
        public bool IsValidparentheses(string s)
        {
            if (s == null) return true;
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                    stack.Push(c);
                else
                {
                    if (stack.Count == 0)
                        return false;
                    char sc = stack.Pop();
                    if (c == ')' && sc != '('
                       || c == '}' && sc != '{'
                       || c == ']' && sc != '['
                    )
                        return false;
                }
            }
            return stack.Count == 0;
        }
        #endregion

        #region next-greater-element-i
        /* The next greater element of some element x in an array is the first greater element that is to the right of x in the same array.

        You are given two distinct 0-indexed integer arrays nums1 and nums2, where nums1 is a subset of nums2.
        
        For each 0 <= i < nums1.length, find the index j such that nums1[i] == nums2[j] and determine the next greater element of nums2[j] in nums2. If there is no next greater element, then the answer for this query is -1.
        
        Return an array ans of length nums1.length such that ans[i] is the next greater element as described above.
        
         
        
        Example 1:
        
        Input: nums1 = [4,1,2], nums2 = [1,3,4,2]
        Output: [-1,3,-1]
        Explanation: The next greater element for each value of nums1 is as follows:
        - 4 is underlined in nums2 = [1,3,4,2]. There is no next greater element, so the answer is -1.
        - 1 is underlined in nums2 = [1,3,4,2]. The next greater element is 3.
        - 2 is underlined in nums2 = [1,3,4,2]. There is no next greater element, so the answer is -1.
         */

        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            int[] arr = new int[nums1.Length];
            Stack<int> stack = new Stack<int>();
            Dictionary<int, int> dc = new Dictionary<int, int>();

            for (int i = 0; i < nums2.Length; i++)
            {
                while (stack.Count > 0 && nums2[i] > stack.Peek())
                    dc[stack.Pop()] = nums2[i];
                stack.Push(nums2[i]);
            }
            while (stack.Count > 0)
            {
                dc[stack.Pop()] = -1;
            }
            for (int i = 0; i < nums1.Length; i++)
                arr[i] = dc[nums1[i]];

            return arr;
        }
        #endregion
    }
}

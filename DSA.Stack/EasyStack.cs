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
    }
}

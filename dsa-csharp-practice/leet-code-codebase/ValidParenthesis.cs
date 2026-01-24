public class Solution{
    public bool IsValid(string s){
        // Stack to store opening brackets
        Stack<char> stack = new Stack<char>();
        // Traverse each character in the string
        foreach(char ch in s){
            // If opening bracket, push into tack
            if(ch == '(' || ch == '{' || ch == '['){
                stack.Push(ch);
            }
            else{
                // If stack is empty, no matching opening bracket
                if(stack.Count == 0){
                    return false;
                }
                // Pop the top element
                char top = stack.Pop();
                // Check for matching brackets
                if(ch == ')' && top != '(') return false;
                if(ch == '}' && top != '{') return false;
                if(ch == ']' && top != '[') return false;
            }
        }
        // Stack should be empty at the end
        return stack.Count == 0;
    }
}

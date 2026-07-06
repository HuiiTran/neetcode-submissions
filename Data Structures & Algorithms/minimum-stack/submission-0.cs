public class MinStack {
    private Stack<int> stack;
    public MinStack() {
        stack = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
    }
    
    public void Pop() {
        stack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        Stack<int> temp = new Stack<int>();
        int min = stack.Peek();
        while(stack.Count > 0){
            int curr = stack.Pop();
            if(min > curr) min = curr;
            temp.Push(curr);
        }

        while(temp.Count > 0){
            stack.Push(temp.Pop());
        }
        return min;
    }
}

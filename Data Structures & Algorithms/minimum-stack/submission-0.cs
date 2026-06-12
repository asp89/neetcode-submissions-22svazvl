public class MinStack {

    Stack<int> stack = new();
    Stack<int> minStack = new();

    public MinStack() {
        
    }
    
    public void Push(int val) {
        stack.Push(val);

        if (minStack.Count == 0 || val <= minStack.Peek())
            minStack.Push(val);
        else
            minStack.Push(minStack.Peek());
    }
    
    public void Pop() {
        if (stack.Count == 0)
            return;

        stack.Pop();
        minStack.Pop();   
    }
    
    public int Top() {
        if (stack.Count == 0)
            return -1;
        
        return stack.Peek();
    }
    
    public int GetMin() {
        if (minStack.Count == 0) {
            return -1;
        }
        return minStack.Peek();
    }
}

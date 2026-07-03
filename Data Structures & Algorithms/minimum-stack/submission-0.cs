public class MinStack {
    private Stack<int> stack;
    private Stack<int> minStack;

    public MinStack() {
        this.stack = new Stack<int>{};
        this.minStack = new Stack<int>{};
    }
    
    public void Push(int val) {
        stack.Push(val);
        if (minStack.Count == 0 || minStack.Peek() >= val){
            minStack.Push(val);
        }
    }
    
    public void Pop() {
        if (minStack.Peek() == stack.Peek()){
            minStack.Pop();
        }
        stack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}

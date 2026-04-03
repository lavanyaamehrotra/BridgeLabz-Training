class CustomStack{
    private int[] stack;
    private int top;
    //custom stack
    public CustomStack(int size){
        stack = new int[size];
        top = -1;
    }
    //push
    public void Push(int value){
        if (top < stack.Length - 1)
            stack[++top] = value;
    }
    //pop
    public int Pop(){
        if (top >= 0){
            return stack[top--];
        }
        return -1;
    }
    //isempty
    public bool IsEmpty(){
        return top == -1;
    }
}

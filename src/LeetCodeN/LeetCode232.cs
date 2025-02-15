namespace Algorithm.LeetCode;

public class MyQueue<T>
{
    private readonly Stack<T> inStack;
    private readonly Stack<T> outStack;


    public MyQueue()
    {
        this.inStack = new();
        this.outStack = new();
    }

    public void Push(T x)
    {
        this.inStack.Push(x);
        this.InToOut();
    }

    public T Pop()
    {
        this.InToOut();
        return this.outStack.Pop();
    }

    public T Peek()
    {
        this.InToOut();
        return this.inStack.Peek();
    }

    public bool Empty()
    {
        return this.inStack.Count <= 0 && this.outStack.Count <= 0;
    }

    private void InToOut()
    {
        if (this.outStack.Count <= 0)
        {
            while (this.inStack.Count > 0)
            {
                this.outStack.Push(this.inStack.Pop());
            }
        }
    }
}

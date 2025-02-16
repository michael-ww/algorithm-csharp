namespace Belly.Algorithm.LeetCode;

public class MinStack<T> where T : IComparable<T>
{
    private readonly Stack<T> data;
    private readonly Stack<T> min;

    public MinStack()
    {
        this.data = new();
        this.min = new();
    }

    public void Push(T val)
    {
        this.data.Push(val);
        if (this.min.Count <= 0 || this.min.Peek().CompareTo(val) > 0)
        {
            this.min.Push(val);
        }
        else
        {
            this.min.Push(this.min.Peek());
        }
    }

    public T Pop()
    {
        this.min.Pop();
        return this.data.Pop();
    }

    public T Top()
    {
        return this.data.Peek();
    }

    public T GetMin()
    {
        return this.min.Peek();
    }
}

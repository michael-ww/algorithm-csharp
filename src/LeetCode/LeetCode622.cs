namespace Belly.Algorithm.LeetCode;

public class MyCircularQueue
{
    private readonly int[] queue;
    private int left;
    private int right;
    private int size;
    private readonly int capacity;

    public MyCircularQueue(int k)
    {
        this.queue = new int[k];
        this.left = 0;
        this.right = 0;
        this.size = 0;
        this.capacity = k;
    }

    public bool Enqueue(int value)
    {
        if (this.IsFull())
        {
            return false;
        }
        this.queue[right] = value;
        this.right = this.right == this.capacity - 1 ? 0 : (this.right + 1);
        this.size++;
        return true;
    }

    public bool Dequeue()
    {
        if (this.IsEmpty())
        {
            return false;
        }
        int pivot = this.queue[this.left];
        left = left == this.capacity - 1 ? 0 : left++;
        this.size--;
        return true;
    }

    public int Front()
    {
        if (this.IsEmpty())
        {
            return -1;
        }
        return this.queue[this.left];
    }

    public int Rear()
    {
        if (this.IsEmpty())
        {
            return -1;
        }
        int last = this.right == 0 ? (this.capacity - 1) : (this.right - 1);
        return this.queue[last];
    }

    public bool IsEmpty()
    {
        return this.size == 0;
    }

    public bool IsFull()
    {
        return this.size == this.capacity;
    }
}

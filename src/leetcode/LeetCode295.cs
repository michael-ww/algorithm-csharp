namespace Algorithm.LeetCode;

public class MedianFinder
{
    private readonly PriorityQueue<int, int> smallRootHeap;
    private readonly PriorityQueue<int, int> bigRootHeap;

    public MedianFinder()
    {
        this.smallRootHeap = new(Comparer<int>.Default);
        this.bigRootHeap = new(Comparer<int>.Create((int x, int y) => y - x));
    }
    public void AddNum(int num)
    {
        if (this.bigRootHeap.Count <= 0 || this.bigRootHeap.Peek() >= num)
        {
            this.bigRootHeap.Enqueue(num, num);
        }
        else
        {
            this.smallRootHeap.Enqueue(num, num);
        }
        this.Balance();
    }

    public double FindMedian()
    {
        if (this.bigRootHeap.Count <= 0 && this.smallRootHeap.Count <= 0)
        {
            throw new InvalidOperationException("No Element");
        }
        if (this.bigRootHeap.Count == this.smallRootHeap.Count)
        {
            return (this.bigRootHeap.Peek() + this.smallRootHeap.Peek()) / 2d;
        }
        else
        {
            return this.bigRootHeap.Count > this.smallRootHeap.Count ? this.bigRootHeap.Peek() : this.smallRootHeap.Peek();
        }
    }

    private void Balance()
    {
        while (Math.Abs(this.bigRootHeap.Count - this.smallRootHeap.Count) > 1)
        {
            if (this.bigRootHeap.Count > this.smallRootHeap.Count)
            {
                int num = this.bigRootHeap.Dequeue();
                this.smallRootHeap.Enqueue(num, num);
            }
            else
            {
                int num = this.smallRootHeap.Dequeue();
                this.bigRootHeap.Enqueue(num, num);
            }
        }
    }
}

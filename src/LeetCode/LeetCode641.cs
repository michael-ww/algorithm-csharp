namespace Algorithm.LeetCode;

public class MyCircularDeque
{
    private ListNode head;
    private ListNode tail;
    private int size;
    private int limit;

    public MyCircularDeque(int k)
    {
        this.head = null;
        this.tail = null;
        this.size = 0;
        this.limit = k;
    }

    public bool InsertFront(int value)
    {
        if (this.IsFull())
        {
            return false;
        }
        if (this.IsEmpty())
        {
            this.head = new(value);
            this.tail = this.head;
        }
        else
        {
            this.head.Previous = new(value)
            {
                Next = this.head
            };
            this.head = this.head.Previous;
        }
        this.size++;
        return true;
    }

    public bool InsertLast(int value)
    {
        if (this.IsFull())
        {
            return false;
        }
        if (this.IsEmpty())
        {
            this.head = new(value);
            this.tail = this.head;
        }
        else
        {
            this.tail.Next = new(value)
            {
                Previous = this.tail
            };
            this.tail = this.tail.Next;
        }
        this.size++;
        return true;
    }

    public bool DeleteFront()
    {
        if (this.IsEmpty())
        {
            return false;
        }
        ListNode next = this.head.Next;
        this.head.Next = null;
        next.Previous = null;
        this.head = next;
        this.size--;
        return true;
    }

    public bool DeleteLast()
    {
        if (this.IsEmpty())
        {
            return false;
        }
        ListNode last = this.tail.Previous;
        this.tail.Previous = null;
        last.Next = null;
        this.tail = last;
        this.size--;
        return true;
    }

    public int GetFront()
    {
        if (this.IsEmpty())
        {
            return -1;
        }
        return this.head.Value;
    }

    public int GetRear()
    {
        if (this.IsEmpty())
        {
            return -1;
        }
        return this.tail.Value;
    }

    public bool IsEmpty()
    {
        return this.size == 0;
    }

    public bool IsFull()
    {
        return this.size == this.limit;
    }
}

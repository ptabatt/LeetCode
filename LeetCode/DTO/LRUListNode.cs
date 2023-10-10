namespace LeetCode
{
    public class LRUListNode
    {
        public int Key;
        public int Val;
        public LRUListNode Next { get; set; }
        public LRUListNode Prev { get; set; }

        public LRUListNode(int key, int val)
        {
            Key = key;
            Val = val;
        }
    }
}

using System.Collections.Generic;

namespace LeetCode
{
    public class LRUCache
    {
        private int _capacity;
        private Dictionary<int, LRUListNode> _dic;
        private LRUListNode _head;
        private LRUListNode _tail; 

        public LRUCache(int capacity)
        {
            _capacity = capacity;
            _dic = new Dictionary<int, LRUListNode>();
            _head = new LRUListNode(-1, -1);
            _tail = new LRUListNode(-1, -1);
            _head.Next = _tail;
            _tail.Prev = _head;
        }

        public int Get(int key)
        {
            if (_dic.TryGetValue(key, out var node))
            {
                Remove(node);
                Add(node);
                return node.Val;
            }
            else
            {
                return -1;
            }

        }

        public void Put(int key, int value)
        {
            if (_dic.ContainsKey(key))
            {
                var oldNode = _dic[key];
                Remove(oldNode);
            }

            var node = new LRUListNode(key, value);
            _dic[key] = node;
            Add(node);

            if (_dic.Count > _capacity)
            {
                var nodeToDelete = _head.Next;
                Remove(nodeToDelete);
                _dic.Remove(nodeToDelete.Key);
            }
        }

        private void Add(LRUListNode node)
        {
            var previousEnd = _tail.Prev;
            previousEnd.Next = node;
            node.Prev = previousEnd;
            node.Next = _tail;
            _tail.Prev = node;
        }

        private void Remove(LRUListNode node)
        {
            node.Prev.Next = node.Next;
            node.Next.Prev = node.Prev;
        }
    }
}

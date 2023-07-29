using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_23
{
    using System;
    using System.Collections.Concurrent;

    public class ConcurrentGenericQueue<T>
    {
        private readonly ConcurrentQueue<T> _queue;
        private readonly int _maxLength;

        public ConcurrentGenericQueue(int maxLength)
        {
            if (maxLength <= 0)
            {
                throw new ArgumentException("Max length should be greater than 0.", nameof(maxLength));
            }

            _queue = new ConcurrentQueue<T>();
            _maxLength = maxLength;
        }

        public void Enqueue(T item)
        {
            if (_queue.Count >= _maxLength)
            {
                throw new InvalidOperationException("Queue is full.");
            }

            _queue.Enqueue(item);
        }

        public T Dequeue()
        {
            if (!_queue.TryDequeue(out T item))
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            return item;
        }

        public int GetCurrentLength()
        {
            return _queue.Count;
        }

        public T Peek()
        {
            if (!_queue.TryPeek(out T item))
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            return item;
        }
    }


}

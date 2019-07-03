using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedList.Model
{
    public class DuplexLinkedList<T> : IEnumerable<T>
    {
        public DuplexItem<T> Head { get; set; }
        public DuplexItem<T> Tail { get; set; }
        public int Count { get; set; }

        public DuplexLinkedList(T data)
        {
            var item = new DuplexItem<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public DuplexLinkedList() { }

        public void Add(T data)
        {
            var item = new DuplexItem<T>(data);

            if (Count == 0)
            {
                Head = item;
                Tail = item;
                Count = 1;
                return;
            }

            Tail.Next = item;
            item.Previos = Tail;
            Tail = item;
            Count++;
        }

        public void Delete(T data)
        {
            var current = Head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    current.Previos.Next = current.Next;
                    current.Next.Previos = current.Previos;
                    Count--;
                    return;
                }
                else
                {
                    current = current.Next;
                }
            }
        }

        public DuplexLinkedList<T> Reverse()
        {
            var result = new DuplexLinkedList<T>();

            var current = Tail;

            while (current != null)
            {
                result.Add(current.Data);
                current = current.Previos;
            }

            return result;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;

            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }
    }
}

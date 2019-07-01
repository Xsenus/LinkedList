using System;
using System.Collections;

namespace LinkedList.Model
{
    /// <summary>
    /// Односвязный список
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedList<T> : IEnumerable
    {
        /// <summary>
        /// Первый элемент списка.
        /// </summary>
        public Item<T> Head { get; private set; }

        /// <summary>
        /// Последний элемент списка.
        /// </summary>
        public Item<T> Tail { get; private set; }

        /// <summary>
        /// Количество элементов в списке.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Создать пустой список.
        /// </summary>
        public LinkedList()
        {
            Clear();
        }

        /// <summary>
        /// Создать список с начальным элементов.
        /// </summary>
        /// <param name="data"></param>
        public LinkedList(T data)
        {            
            SetHeadAndTail(data);
        }

        /// <summary>
        /// Добавить данные в конец списка.
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            if (Tail != null)
            {
                var item = new Item<T>(data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }

        /// <summary>
        /// Удалить первое вхождение данных в список.
        /// </summary>
        /// <param name="data"></param>
        public void Delelete(T data)
        {
            if (Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                var current = Head.Next;
                var previous = Head;                

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }

                    previous = current;
                    current = current.Next;
                }
            }
            else
            {
                SetHeadAndTail(data);
            }
        }

        /// <summary>
        /// Добавить данные в начало списка.
        /// </summary>
        /// <param name="data"></param>
        public void AppendHead(T data)
        {
            var item = new Item<T>(data);
            item.Next = Head;
            Head = item;
            Count++;
        }

        /// <summary>
        /// Вставить данные после искомого значения.
        /// </summary>
        /// <param name="target">"Элемент после которого надо вставить data</param>
        /// <param name="data"></param>
        public void InsertAfter(T target, T data)
        {
            if (Head != null)
            {                
                var current = Head;

                while (current != null)
                {
                    if (current.Data.Equals(target))
                    {
                        var item = new Item<T>(data);
                        item.Next = current.Next;
                        current.Next = item;
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
            else
            {
                /*
                 * Или ничего не добавляем
                 * Или добавляем оба элемента
                 */

                //SetHeadAndTail(target);
                //Add(data);
            }
        }

        /// <summary>
        /// Очистить список.
        /// </summary>
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        private void SetHeadAndTail(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        /// <summary>
        /// Получить перечисление всех элементов списка.
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            var current = Head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public override string ToString()
        {
            return "Linked List " + Count + " элементов";
        }
    }
}

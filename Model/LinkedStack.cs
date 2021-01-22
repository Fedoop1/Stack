using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Model
{
    class LinkedStack<T>
    {
        private int Count = 0;
        private bool isEmpty => Count == 0;
        private Item<T> Head { get; set; }

        public LinkedStack(T Data)
        {
            Item<T> item = new Item<T>(Data);
            Head = item;
            Count++;
        }

        public LinkedStack()
        {
            Head = null;
        }

        public void Push(T Data)
        {
            var item = new Item<T>(Data);
            item.previousItem = Head;
            Head = item;
            Count++;
        }

        public T Peek()
        {
            return Head._data;
        }

        public T Pop()
        {
            if (!isEmpty)
            {
                var item = Head;
                Head = Head.previousItem;
                Count--;
                return item._data;
            }
            else throw new ArgumentOutOfRangeException("Stack is empty");
        }

        public override string ToString()
        {
            return $"Stack has {Count} elements.";
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Model
{
    public class SimpleStack<T>
    {
        private List<T> StackData = new List<T>();
        private int Count = 0;
        private bool isEmpty => StackData.Count == 0;
        public void Push(T item)
        {
            StackData.Add(item);
            Count++;
        }

        public T Peek()
        {
            if(!isEmpty)
            {
                return StackData.LastOrDefault();
            }
            else throw new ArgumentOutOfRangeException("Stack is empty");
        }

        public T Pop()
        {
            if(!isEmpty)
            {
                var item = StackData.LastOrDefault();
                StackData.Remove(item);
                Count--;
                return item;
            }
            else throw new ArgumentOutOfRangeException("Stack is empty");
        }

        public override string ToString()
        {
            return $"Stack has {Count} elements.";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Model
{
    class ArrayStack<T>
    {
        private T[] StackData;
        private int size = 10;
        private int count = -1;

        public ArrayStack(T Data, int size)
        {
            StackData = new T[size];
            StackData[0] = Data;
            count++;
        }

        public ArrayStack(T Data)
        {
            StackData = new T[size];
            StackData[0] = Data;
            count++;
        }
        public ArrayStack()
        {
            StackData = new T[size];
        }

        public void Push(T Data)
        {
            count++;
            if (count < size)
            {
                StackData[count] = Data;
            }
            else throw new StackOverflowException("Stack is overflowed");
        }

        public T Peek()
        {
            return StackData[count];
        }

        public T Pop()
        {
            if (count >= 0)
            {
                var item = StackData[count];
                count--;
                return item;
            }
            else throw new ArgumentOutOfRangeException("Stack is empty");
        }

        public override string ToString()
        {
            return $"Stack has {count + 1} elements.";
        }

    }
}

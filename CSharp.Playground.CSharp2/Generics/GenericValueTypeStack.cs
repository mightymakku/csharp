namespace CSharp.Playground.CSharp2.Generics
{
    using System;

    public class GenericValueTypeStack<T>
        where T : struct
    {
        private T[] _buffer;
        private int _top;

        public GenericValueTypeStack(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentOutOfRangeException("size", "Must be greater than zero.");
            }

            _buffer = new T[size];
            _top = 0;
        }

        public void Push(T value)
        {
            if (_top == _buffer.Length)
            {
                throw new InvalidOperationException("No more space on the stack.");
            }

            _buffer[_top++] = value;
        }

        public T Pop()
        {
            if (_top == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return _buffer[--_top];
        }
    }
}

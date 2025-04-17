using System;
using System.Text;

namespace Util
{
    public class CircularBuffer<T>
    {
        private int head = 0;
        private int tail = 0;

        private T?[] buffer;

        public CircularBuffer(uint size)
        {
            if (size > 1)
            {
                buffer = new T?[size];
            }
            else
            {
                throw new Exception($"ERROR: \"{size}\" is no valid size for CircularBuffer");
            }
        }

        public void Add(T t)
        {
            buffer[tail] = t;
            wrapAdd(ref tail);

            if (tail == head) wrapAdd(ref head);
        }

        public T? Read()
        {
            if (head == tail) return default(T);

            T? val = buffer[head];

            wrapAdd(ref head);
            return val;
        }

        private void wrapAdd(ref int val)
        {
            val++;

            if (val >= buffer.Length) val = 0;
        }

        // Debug features
        public string ToString()
        {
            StringBuilder sb = new();

            for (int i = 0; i < buffer.Length; i++)
            {
                string pre = i == head ? "\x1B[42m[\x1B[0m" : "[";
                string suf = i == tail ? "\x1B[44m]\x1B[0m" : "]";

                if (i != buffer.Length - 1) suf += ", ";
                sb.Append($"{pre}{buffer[i]}{suf}");
            }

            return sb.ToString();
        }
    }
}

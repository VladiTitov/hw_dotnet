using System;
using System.Diagnostics;
using System.Linq;

namespace HW04.Task03
{
    public class Task
    {
        private readonly long[] _arrayTask;

        public Task(int arrayLong) =>
            _arrayTask = CreateArrayLinq(arrayLong);

        public void Start()
        {
            ArrayCreateTimer("Самописный Reverse", Reverse, new Stopwatch());
            ArrayCreateTimer("Оригинальный Reverse", Array.Reverse, new Stopwatch());
        }

        private long[] CreateArrayLinq(int range)
        {
            Random random = new Random();
            return Enumerable.Range(0, range).Select(a => (long)random.Next(15)).ToArray();
        }

        private void Reverse(long[] array)
        {
            int lenghtArray = array.Length - 1;
            int index = 0;
            int step = 0;
            do
            {
                Replace(ref array[index + step], ref array[lenghtArray - step]);
                step++;
            } 
            while (!Stop(index + step, lenghtArray - step));
        }

        private bool Stop(int startIndex, int endIndex) => 
            (startIndex - endIndex == 0 || startIndex - endIndex == 1);

        private void Replace(ref long item1, ref long item2)
        {
            long temp = item1;
            item1 = item2;
            item2 = temp;
        }

        private void ArrayCreateTimer(string name, Action<long[]> func, Stopwatch sw)
        {
            sw.Start();
            func(_arrayTask);
            sw.Stop();
            Console.WriteLine($"{name} выполнил задачу за {sw.ElapsedMilliseconds} милисекунд");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            storage<int> StorageInt = new storage<int>();
            storage<string> StorageString = new storage<string>();

            StorageInt.mengisi(10);
            StorageString.mengisi("Hello broski");
        }
    class storage<T>
        {
            public T Value;
                
            public void mengisi(T value)
            {
                Value = value;
                Console.WriteLine(value);
            }
        }
    }
}

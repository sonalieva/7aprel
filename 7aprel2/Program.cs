using System;
using System.Collections.Generic;

namespace _7aprel2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(21);
            myStack.Push(22);
            myStack.Push(23);
            myStack.Push(24);
            myStack.Push(25);
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("peek: " + myStack.Peek());
            Console.WriteLine("pop: " + myStack.Pop());
            Console.WriteLine("peek: " + myStack.Peek());
            Console.WriteLine("pop: " + myStack.Pop());


            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(21);
            myQueue.Enqueue(22);
            myQueue.Enqueue(23);
            myQueue.Enqueue(24);
            myQueue.Enqueue(25);
            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("peek: " + myQueue.Peek());
            Console.WriteLine("dequeue: " + myQueue.Dequeue());
            Console.WriteLine("peek: " + myQueue.Peek());
            Console.WriteLine("dequeue: " + myQueue.Dequeue());


            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Sona");
            dic.Add(2, "Sugra");
            dic.Add(3, "Khanim");
            dic.Add(4, "Ferid");
            dic.Add(5, "Aitan");
            dic.Remove(1);
            if (dic.ContainsKey(2))
            {
                dic.Remove(2);
            }
            foreach (var num in dic)
            {
                Console.WriteLine(num);
            }
            

            foreach (var key in dic.Keys)
            {
                Console.WriteLine("key: " + key);
            }



            HashSet<string> myhash1 = new HashSet<string>();
    
            myhash1.Add("Baki");
            myhash1.Add("Gence");
            myhash1.Add("Sumqayit");
            myhash1.Add("Agdam");
            myhash1.Add("Berde");

            myhash1.Remove("Agdam");
            Console.WriteLine("my hash-1");
            foreach (var h in myhash1)
            {
                Console.WriteLine(h);
            }
            Console.WriteLine("myHash count:" + myhash1.Count);
        }
    }
}

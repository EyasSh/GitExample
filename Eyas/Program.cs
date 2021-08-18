using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Text;
using System.Threading;

namespace Eyas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region extention methods
            //extention methods
           // 100.ToEyasstr();

            #endregion extention methods
            Console.WriteLine("_____________________________________________________________");
            //**********************************
            #region Linq & extras
            //int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Index a1 = 3;
            //Index a2 = ^3;
            //var b = a[a1..a2];
            //foreach(var i in b)
            //{
            //    Console.WriteLine(i);
            //}
            //var e=from i in a where i >= 5 select i;
            
            //foreach (var i in e)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion Linq & extras
            Console.WriteLine("___________________________________________________________");
            #region Generics
            // EyasList<dynamic> eyas=new EyasList<dynamic>();
            //eyas.AddHead(300);
            //eyas.AddHead("Alon");
            //eyas.AddHead(true);
            //foreach (dynamic L in eyas)
            //    Console.WriteLine(L);
            #endregion Generics
            Console.WriteLine("__________________________________________________________");

            #region delegates
            //MyDel r = new MyDel(LastOt);
            //Console.WriteLine(r("Hello"));
            #endregion delegates
            Console.WriteLine("__________________________________________________________");
            #region tuples
            //var tup =(1,2,3,4,5,6);
            #endregion tuples

            Console.WriteLine(@"hi ");
            
        }
        public delegate string MyDel(string msg);
        public  static string LastOt(string l) => l[l.Length - 1].ToString();
    }

    public static class Extentions
    {
        public static void ToEyasstr(this object o)
        {
            Console.WriteLine("eyas "+o.ToString());
        }
    }
    public class EyasList<T>
    {
        private class Node
        {
            // T used in non-generic constructor.
            public Node(T t)
            {
                next = null;
                data = t;
            }

            private Node next;
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }

            // T as private member data type.
            private T data;

            // T as return type of property.
            public T Data
            {
                get { return data; }
                set { data = value; }
            }
        }

        private Node head;

        // constructor
        public EyasList()
        {
            head = null;
        }

        // T as method parameter type:
        public void AddHead(T t)
        {
            Node n = new Node(t);
            n.Next = head;
            head = n;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
    
}
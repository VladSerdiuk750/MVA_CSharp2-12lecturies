using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            Console.WriteLine(list[3]);
        }
        class MyClass
        {
            private string firstName;
            private string lastName;
            public string Name
            {
                get
                {
                    return firstName + " " + lastName;
                }
            }
        }
        class MyList
        {
            public int this [int index]
            {
                get
                {
                    return 0;
                }
                set
                {

                }
            }
            Node root;
            public class Node
            {
                public int Data { get; set; }
                public Node Next { get; set; }
            }
        }
    }
}

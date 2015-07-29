using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGenericCollection
{
   internal sealed class Program
    {
        static void Main(string[] args)
        {
            
            using (new Watcher("Adding to my collection"))
            {
                MyCollection<int> test = new MyCollection<int>();
                test.Add(3);
                test.Add(4);
                test.Add(5);
                test.Add(363);
                test.Add(8);
                test.Add(45);
            }
            using (new Watcher("Adding to List<int>"))
            {
                List<int> test = new List<int>();
                test.Add(3);
                test.Add(4);
                test.Add(5);
                test.Add(363);
                test.Add(8);
                test.Add(45);
            }
            using (new Watcher("Adding to SortedList<int,int>"))
            {
                SortedList<int,int> test = new SortedList<int, int>();
                test.Add(3,3);
                test.Add(4,4);
                test.Add(5,5);
                test.Add(363,363);
                test.Add(8,8);
                test.Add(45,45);
            }

            Console.ReadLine();
        }
    }
}

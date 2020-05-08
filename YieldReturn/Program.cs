using System;
using System.Collections.Generic;

namespace YieldReturn
{
    class Program
    {
        public static IEnumerable<int> MyList =
            new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        static void Main(string[] args)
        {
            foreach (var i in Filter())
            {
                Console.WriteLine(i);
                //next step back to filter
            }

        }

        public static IEnumerable<int> Filter()
        {
            foreach (var i in MyList)
            {
                if (i % 3 == 0)
                {
                    //return to caller
                    yield return i;
                }
            }
        }

        public static IEnumerable<int> Filter1()
        {
            var temp=new List<int>();
            foreach (var i in MyList)
            {
                if (i % 3 == 0)
                {
                    temp.Add(i);
                }
            }
            return temp;
        }
    }
}

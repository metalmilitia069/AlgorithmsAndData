using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSolution2Algorithms
{
    class ListBuiltIn
    {
        public static void ApiMembers()
        {
            var list = new List<int>() { 1, 0, 5, 3, 4 };
            PrintTheList(list);
            list.Sort();
            PrintTheList(list);

        }

        public static void PrintTheList(List<int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }


        public static void RunList()
        {
            List<int> list = new List<int>();
            LogCountAndCapacity(list);

            for (int i = 0; i < 16; i++)
            {
                list.Add(i);
                LogCountAndCapacity(list);
            }

            Console.WriteLine();

            for (int i = 10; i > 0; i--)
            {
                list.RemoveAt(i - 1);
                LogCountAndCapacity(list);
            }

            list.TrimExcess();

            LogCountAndCapacity(list);

            list.Add(1);

            LogCountAndCapacity(list);
        }

        public static void LogCountAndCapacity(List<int> list)
        {
            Console.WriteLine($"Count = {list.Count}, Capacity = {list.Capacity}");
        }
    }
}

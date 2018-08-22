using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_space
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            int rest = 0;
            int count = 16;
            int cubicle = 4;
            int[] cubicles = Enumerable.Range(4, 64).Where(c => c % 4 == 0).ToArray();
         
            Dictionary<int, int> list = new Dictionary<int, int>();

            Dictionary<int, int> flour = new Dictionary<int, int>();

            for (int i = 1; i < 4; i++)
            {
                flour[i] = count;
            }

            list.Add(2, cubicles.SkipWhile(i => i < 2 * 7).ToArray()[0] / cubicle);
            list.Add(3, cubicles.SkipWhile(i => i < 3 * 7).ToArray()[0] / cubicle);
            list.Add(6, cubicles.SkipWhile(i => i < 6 * 7).ToArray()[0] / cubicle);
            list.Add(8, cubicles.SkipWhile(i => i < 8 * 7).ToArray()[0] / cubicle);
            list.Add(5, cubicles.SkipWhile(i => i < 5 * 7).ToArray()[0] / cubicle);

            //while ((line = Console.ReadLine()) != null && line != "")
            //{
            //    int el = int.Parse(line) * 7;                                                                                                                           
            //    int  elem = cubicles.SkipWhile(i =>  i < el ).ToArray()[0]/ cubicle;
            //    list.Add(elem);
            //}

            Method(list, flour, k, rest);
        }

        public static void Method(Dictionary<int, int> list, Dictionary<int, int> flour, int k, int rest)
        {
            int allFlour = flour[k];
            if (list.Sum(i => i.Value) > 0)
            {
                if (list.TakeWhile(r => r.Value < rest || r.Value < allFlour).Count() > 0)
                {
                    int max = rest > 0 ? list.TakeWhile(r => r.Value < rest).Max(i => i.Value) : list.TakeWhile(r => r.Value < allFlour).Max(i => i.Value);

                    rest = rest > 0 ? rest - max : allFlour - max;

                    int idx = list.Where(i => i.Value == max).ToArray()[0].Key;

                    var key = list.Keys.ToList().FindIndex(i => i == idx) + 1;

                    list[idx] = 0;

                    Console.WriteLine(" Floor {0} - project #{1}, {2} team", k, key, idx);
                }
                if (list.TakeWhile(r => r.Value < rest && r.Value != 0).Count() == 0 && k < flour.Count())
                {
                    k++;
                    Method(list, flour, k, rest = 0);
                }

                Method(list, flour, k, rest);
            }
        }
    }
}





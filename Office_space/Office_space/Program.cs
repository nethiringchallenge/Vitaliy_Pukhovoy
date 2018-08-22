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
            int k = 1;  //flour
            int rest = 0; //rest cubicles on flour
            int count = 16; // nubber cubicles on one flour
            int cubicle = 4; //number of person of cubicle
            int pesonInTeam = 7; // number of person in Team
            int[] cubicles = Enumerable.Range(4, 64).Where(c => c % 4 == 0).ToArray();
            int[] data = { 2, 3, 6, 8, 5 }; // enter data of teams

            Dictionary<int, int> dic = new Dictionary<int, int>(); //number cubicles for each team

            int[] flour = new int[3];                              // number of cubicles on each flour
            flour = Enumerable.Repeat(count, 3).ToArray();

            //enter manually
            //while ((line = Console.ReadLine()) != null && line != "")
            //{
            //    int el = int.Parse(line) * 7;                                                                                                                           
            //    int  elem = cubicles.SkipWhile(i =>  i < el ).ToArray()[0]/ cubicle;
            //    list.Add(elem);
            //}

            // enter data auto
            AddCubicleToDictionary(dic, data, cubicles, cubicle, pesonInTeam);

            Method(dic, flour, k, rest);
        }

        public static void AddCubicleToDictionary(Dictionary<int, int> dic, int[] data, int[] cubicles, int cubicle, int pesonInTeam)
        {
            if (data.Count() != 0)
                Array.ForEach(data, d => dic.Add(d, cubicles.SkipWhile(i => i < d * pesonInTeam).ToArray()[0] / cubicle));
            else
                Console.WriteLine("Bitte enter data");
        }

        public static void Method(Dictionary<int, int> dic, int[] flour, int k, int rest)
        {
            int allFlour = 0;
            try
            {
                allFlour = flour[k - 1];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (dic.Sum(i => i.Value) > 0)
            {
                if (dic.TakeWhile(r => r.Value < rest || r.Value < allFlour).Count() > 0)
                {
                    int max = rest > 0 ? dic.TakeWhile(r => r.Value < rest).Max(i => i.Value) : dic.TakeWhile(r => r.Value < allFlour).Max(i => i.Value);

                    rest = rest > 0 ? rest - max : allFlour - max;

                    int idx = dic.Where(i => i.Value == max).ToArray()[0].Key;

                    var key = dic.Keys.ToList().FindIndex(i => i == idx) + 1;
                    try
                    {
                        dic[idx] = 0;
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    Console.WriteLine(" Floor {0} - project #{1}, {2} team", k, key, idx);
                }
                if (dic.TakeWhile(r => r.Value < rest && r.Value != 0).Count() == 0 && k < flour.Count())
                {
                    k++;
                    Method(dic, flour, k, rest = 0);
                }

                Method(dic, flour, k, rest);
            }
        }
    }
}





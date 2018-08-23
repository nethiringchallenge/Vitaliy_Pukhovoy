using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Unit_Office_Space")]
namespace OfficeSpace
{
   internal  class FindingSpaceForTeam : IFindingSpace
    {
        private Dictionary<int, int> dic;
        private int[] cubicles;
        private int cubicle, personInTeam;        

        public FindingSpaceForTeam(Dictionary<int, int> _dic, int[] _cubicles, int _cubicle, int _personInTeam)
        {
           dic = _dic;
           cubicles = _cubicles;
           cubicle = _cubicle;
           personInTeam = _personInTeam;
        }

        public void Method( int[] flour, int k, int rest)
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
                    Method(flour, k, rest = 0);
                }

                Method(flour, k, rest);
            }
        }       

    }
}

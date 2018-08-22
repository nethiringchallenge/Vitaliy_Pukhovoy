using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("OfficeSpaceUnitTest")]
namespace Office_space
{
    class FindingSpaceForTeam : IFindingSpace, IFillingData
    {
        public void Method(Dictionary<int, int> dic, int[] flour, int k, int rest)
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

        public void AddCubicleToDictionary(Dictionary<int, int> dic, int[] data, int[] cubicles, int cubicle, int personInTeam)
        {
            if (data.Count() != 0)
                Array.ForEach(data, d => dic.Add(d, cubicles.SkipWhile(i => i < d * personInTeam).ToArray()[0] / cubicle));
            else
                Console.WriteLine("Bitte enter data");
        }

        public void AddDataManually(Dictionary<int, int> dic, int[] cubicles, int cubicle, int personInTeam)
        {
            string line;
            //enter manually
            while ((line = Console.ReadLine()) != null && line != "")
            {
                int el = int.Parse(line) * 7;
                int elem = cubicles.SkipWhile(i => i < el * personInTeam).ToArray()[0] / cubicle;
                dic.Add(el, elem);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSpace
{
    class FillingData : IFillingData
    {
        private Dictionary<int, int> dic;
        public FillingData(Dictionary<int, int>  _dic)
        {
            dic = _dic;
        }

        public void AddCubicleToDictionary(int[] data , int[] cubicles, int cubicle, int personInTeam)
        {
            if (data.Count() != 0)
                Array.ForEach(data, d => dic.Add(d, cubicles.SkipWhile(i => i < d * personInTeam).ToArray()[0] / cubicle));
            else
                Console.WriteLine("Bitte enter data");
        }

        public void AddDataManually(int[] cubicles, int cubicle, int personInTeam)
        {
            string line;
            while ((line = Console.ReadLine()) != null && line != "")
            {
                int el = int.Parse(line) * 7;
                int elem = cubicles.SkipWhile(i => i < el * personInTeam).ToArray()[0] / cubicle;
                dic.Add(el, elem);
            }
        }
    }
}

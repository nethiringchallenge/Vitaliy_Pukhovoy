using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_space
{
    interface IFillingData
    {
        void AddDataManually(Dictionary<int, int> dic, int[] cubicles, int cubicle, int personInTeam);
        void AddCubicleToDictionary(Dictionary<int, int> dic, int[] data, int[] cubicles, int cubicle, int personInTeam);
    }
}

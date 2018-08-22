using Office_space;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("OfficeSpaceUnitTest")]
namespace OfficeSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 1;  //flour
            int rest = 0; //rest cubicles on flour
            int count = 16; // number cubicles on one flour
            int cubicle = 4; //number of person of cubicle
            int personInTeam = 7; // number of person in Team
            int[] cubicles = Enumerable.Range(4, 64).Where(c => c % 4 == 0).ToArray();
            int[] data = { 2, 3, 6, 8, 5 }; // enter data of teams

            Dictionary<int, int> dic = new Dictionary<int, int>(); //number cubicles for each team

            int[] flour = new int[3];                              // number of cubicles on each flour
            flour = Enumerable.Repeat(count, 3).ToArray();

            var sp = new FindingSpaceForTeam();
            sp.AddCubicleToDictionary(dic, data, cubicles, cubicle, personInTeam);  // enter data auto
            sp.Method(dic, flour, k, rest);

        }
    }
}





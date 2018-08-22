using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

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

           //number cubicles for each team

            int[] flour = new int[3];                              // number of cubicles on each flour
            flour = Enumerable.Repeat(count, 3).ToArray();

            var sp = new FindingSpaceForTeam();
            sp.AddCubicleToDictionary( data, cubicles, cubicle, personInTeam);  // enter data auto
            sp.Method(flour, k, rest);
            //sp.AddDataManually                                                    // add data manually

        }
    }
}





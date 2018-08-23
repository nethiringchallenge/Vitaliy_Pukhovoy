using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Autofac;

[assembly: InternalsVisibleTo("OfficeSpaceUnitTest")]
namespace OfficeSpace
{
    class Program
    {                                                                         
        static void Main(string[] args)
        {
            int k = 1;                                                         //flour
            int rest = 0;                                                      //rest cubicles on flour
            int count = 16;                                                    // number cubicles on one flour
            int[] data = { 2, 3, 6, 8, 5 };                                    // enter data of teams 
            int[] flour = new int[3];                                          // number of cubicles on each flour
            flour = Enumerable.Repeat(count, 3).ToArray();
            int cubicle = 4;                                                   //number of person of cubicle
            int personInTeam = 7;                                              // number of person in Team
            int[] cubicles = Enumerable.Range(4, 64).Where(c => c % 4 == 0).ToArray();
            var dic = new Dictionary<int, int>();

        var container =AutofacConfig.ConfigureContainer(dic, cubicles, cubicle, personInTeam);
            using (var scope = container.BeginLifetimeScope())
            {

                IFillingData sp = scope.Resolve<IFillingData>();
                             sp.AddCubicleToDictionary(data);
                             //sp.AddDataManually(cubicles,cubicle,personInTeam)

                IFindingSpace sp2 = scope.Resolve<IFindingSpace>();
                              sp2.Method(flour, k, rest);
            }
                                                                   
        }
    }
}





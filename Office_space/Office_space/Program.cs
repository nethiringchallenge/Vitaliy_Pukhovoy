using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Autofac;

namespace OfficeSpace
{
    class Program
    {                                                                         
        static void Main(string[] args)
        {
            int k = 1;                                                                //flour
            int rest = 0;                                                             //rest cubicles on flour
            int count = 16;                                                           // number cubicles on one flour
            int cubicle = 4;                                                          //number of person of cubicle
            int personInTeam = 7;                                                     // number of person in Team
            int[] data = { 2, 3, 6, 8, 5 };                                           // enter data of teams 
            int[] flour = new int[3];                                                 // number of cubicles on each flour
                  flour = Enumerable.Repeat(count, 3).ToArray();           
            int[] cubicles = Enumerable.Range(4, 64).Where(c => c % 4 == 0).ToArray();//number cubicles on flour
            var dic = new Dictionary<int, int>();

            var container =AutofacConfig.ConfigureContainer(dic, cubicles, cubicle, personInTeam);
            using (var scope = container.BeginLifetimeScope())
            {

                IFillingData sp = scope.Resolve<IFillingData>();
                             sp.AddCubicleToDictionary(data ,cubicles, cubicle, personInTeam);
                             //sp.AddDataManually(cubicles,cubicle,personInTeam) // enter data manually

                IFindingSpace sp2 = scope.Resolve<IFindingSpace>();
                              sp2.Method(flour, k, rest);
            }
                                                                   
        }
    }
}





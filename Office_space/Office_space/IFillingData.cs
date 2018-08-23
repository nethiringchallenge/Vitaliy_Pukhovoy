using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("OfficeSpaceUnitTest")]
namespace OfficeSpace
{
    interface IFillingData
    {
        void AddDataManually(int[] cubicles, int cubicle, int personInTeam);
        void AddCubicleToDictionary(int[] data);
    }
}

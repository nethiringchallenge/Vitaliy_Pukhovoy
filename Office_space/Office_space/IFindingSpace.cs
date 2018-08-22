using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("OfficeSpaceUnitTest")]
namespace Office_space
{
    interface IFindingSpace
    {
        void Method(Dictionary<int, int> dic, int[] flour, int k, int rest);
    }
}

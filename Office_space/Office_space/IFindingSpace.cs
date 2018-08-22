using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


[assembly: InternalsVisibleTo("OfficeSpaceUnitTest")]
namespace OfficeSpace
{
    interface IFindingSpace
    {
        void Method( int[] flour, int k, int rest);
    }
}

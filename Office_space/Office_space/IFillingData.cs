using System.Runtime.CompilerServices;


namespace OfficeSpace
{
    interface IFillingData
    {
        void AddDataManually(int[] cubicles, int cubicle, int personInTeam);
        void AddCubicleToDictionary(int[] data, int[] cubicles, int cubicle, int personInTeam);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_space
{
    class Program
    {
        static void Main(string[] args)
        {
            int  count = 16;
            string line;

            List<int> list = new List<int>();
          
            int[][] arr = new int[3][];
         
            while ((line = Console.ReadLine()) != null && line != "")
            {
                list.Add((int.Parse(line)*7));
            }
                   

            Method(list, arr);

       }

        public static void Method(List<int> list, int [][] arr)
        {
            int rest = 124;
            foreach (var i in list   )
            {
                int c = 0;
                
                int max = list.Max();
                try
                {
                    if (i <= arr[c][rest] && i <= 16 * 4   )
                    {

                        Console.WriteLine(" Floor {0} - project{1}, {2} team", c, max, i);
                       
                        if (arr[c][i]> 4)
                        {
                            rest =    arr[c][124] - i;
                            Method(list, arr);
                            
                        }
                        else
                        {
                            list.RemoveAt(i);
                            c++;
                        }
                    }
                    else
                    {
                        Method(list, arr);
                    }
                }
                catch( ArgumentOutOfRangeException ex)
                {

                    Console.WriteLine(ex.Message);
                    break;

                }
            }

        }
    }
}



///We have the project with 2,3, 6,8, 5 teams
//            ///
//            Every floor has 16 cubicles.

// Run: planApp - p2,3,6,8,5 - c16

//Output:

//            Floor 1 - project #4 (8 teams)

//Floor 2 - project #3 (6 teams); project #1 (2 teams)

//Floor 3 - project #5 (5 teams); project #3 (3 teams)


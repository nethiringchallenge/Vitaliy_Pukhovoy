using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot
{
    class Program
    {
        static void Main(string[] args)
        {

            var s = ReadingFile.GetPath("answers.txt");

            ReadingFile.readFile(s);

           // foreach (var item in ReadingFile.Dic)
           //     Console.WriteLine(item);


            var dq = new ChatBotDownSeq(ReadingFile.Dic);
            dq.BotStrategy();

        }
    }
}

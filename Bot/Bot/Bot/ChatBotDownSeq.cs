using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot
{
    internal class ChatBotDownSeq : IChatBot
    {
        private Dictionary<int, string> dic;
        private Random ram;
        public ChatBotDownSeq(Dictionary<int, string> _dic)
        {
            dic = _dic;
            ram = new Random();
        }
        public void BotStrategy()
        {
          int key = ram.Next(1, dic.Count());
          Console.WriteLine(dic.Where(k=>k.Key== key).Select(d=>d.Value).First());           
        }
    }
}

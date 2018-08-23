using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot
{
    internal class ChatBotUpSeq : IChatBot
    {
        private Dictionary<int, string> dic;
        public ChatBotUpSeq(Dictionary<int, string> _dic)
        {
            dic = _dic;
        }

        public void BotStrategy()
        {



        }
    }
}

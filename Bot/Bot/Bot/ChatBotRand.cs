using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot
{
    internal class ChatBotRand : IChatBot
    {

        private Dictionary<int, string> dic;
        public ChatBotRand(Dictionary<int, string> _dic)
        {
            dic = _dic;       
        }

        public void BotStrategy()
        {



        }

    }
}

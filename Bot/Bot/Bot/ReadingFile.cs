using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot
{
    static class ReadingFile
    {

        static private Dictionary<int, string> dic;

        public static Dictionary<int, string> Dic
        {
            get { return dic; }
            set { dic = value; }
        }
        static ReadingFile()
        {
            dic = new Dictionary<int, string>();
        }
        public static string GetPath(string str)
        {
            var dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var targetPath = Path.Combine(dir, Path.GetDirectoryName(str) + "" + Path.GetFileName(str));
            return targetPath;
        }

        public static void readFile(string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                int idx = 0;
                while ((s = sr.ReadLine()) != null)
                {
                    dic.Add(++idx, s);
                }
            }
        }

    }
}

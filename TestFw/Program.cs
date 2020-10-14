using FileUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFw
{
    class Program
    {
        private static string path = @"RegInfo.json";
        private static Dictionary<string, string> RegDic = new Dictionary<string, string>();
        private static Dictionary<string, string> RegDicResult = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            RegDic.Add("aaaa", "r123456");
            RegDic.Add("bbbb", "r987654");
            FileHelper.SerializeToFile<Dictionary<string, string>>(RegDic, path, out string msg);

            RegDicResult= FileHelper.DeserializeFromFile<Dictionary<string, string>>(path, out msg);
        }
    }
}

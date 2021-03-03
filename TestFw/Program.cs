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
            RegDic.Add("aaaa", "张轩");
            RegDic.Add("bbbb", "r987654");
            FileHelper.SerializeToFile<Dictionary<string, string>>(RegDic, path, out string msg);

            RegDicResult= FileHelper.DeserializeFromFile<Dictionary<string, string>>(path,Encoding.GetEncoding("gb2312"), out msg);

            var model = FileHelper.DeserializeFromFile<ConfigModel>(@"ConfigModel.json", Encoding.GetEncoding("gb2312"), out msg);
        }
    }
}

using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;

namespace FileUtility
{
    public static class FileHelper
    {
        #region 序列化文件到指定文件(暂时是json)

        /// <summary>
        /// 序列化文件到指定文件(暂时是json)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="filePath"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool SerializeToFile<T>(T t, string filePath, out string msg)
        {
            msg = "";
            var ret = true;
            if (t == null)
            {
                msg = "待序列化的对象不能为null";
                ret = false;
                return ret;
            }
            if (string.IsNullOrWhiteSpace(filePath))
            {
                msg = "文件路径不能为空";
                ret = false;
                return ret;
            }
            var s = JsonConvert.SerializeObject(t);
            var bs = Encoding.UTF8.GetBytes(s);
            using (System.IO.FileStream fs = new System.IO.FileStream(filePath, FileMode.Create))
            {
                try
                {
                    fs.Write(bs, 0, bs.Length);
                }
                catch (Exception ex)
                {
                    msg = ex.Message;
                    ret = false;
                }
            }

            return ret;
        }
        #endregion

        #region 从指定文件反序列化(暂时是json,最大支持是1kb)


        public static T DeserializeFromFile<T>(string filePath, out string msg)
        {
            msg = "";
            var result = default(T);
            using (System.IO.FileStream fs = new System.IO.FileStream(filePath, FileMode.Open))
            {
                try
                {
                    var bs = new byte[1024 * 1024];
                    fs.Read(bs, 0, bs.Length);
                    var s = Encoding.UTF8.GetString(bs);
                    result = JsonConvert.DeserializeObject<T>(s);
                }
                catch (Exception ex)
                {

                    msg = ex.Message;
                }
            }

            return result;


        }

        #endregion

    }
}

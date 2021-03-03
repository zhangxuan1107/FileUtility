using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFw
{
    public class ConfigModel
    {
        public string AppName { get; set; }

        public bool AutoRun { get; set; }

        public bool StartShowForm { get; set; }

        public bool IsAutoReg { get; set; }

        public string FactoryNames { get; set; }

        public string QinChuanRegCode { get; set; }

        public bool JdqEnable { get; set; }

        public int DeviceTimeOutSecond { get; set; }

        public string DefaultComName { get; set; }

        public string Environment { get; set; }

        public string UpgradeUrlOfTest { get; set; }

        public string UpgradeUrl { get; set; }

        public bool IsShowReChargeForm { get; set; }

        public string ReChargeUrl { get; set; }

        public bool IsSupportCors { get; set; }

        public bool IsCheckToken { get; set; }

        public string Endpoint { get; set; }
        public string AccessKeyId { get; set; }
        public string AccessKeySecret { get; set; }
        public string BucketName { get; set; }

        public bool IsEnableWatch { get; set; }

        public int WatcherInterval { get; set; }

        public string WatchedProcessName { get; set; }


    }
}

using System;
using System.Collections;
using TransparentAgent.BaseClient;
using TransparentAgent.Contract;
using TransparentAgent.Infrastructure;

namespace WCFClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = "jxkejixu".Encryptogram();
            var dKey = key.Decryptogram();
            var encrypeStr = ("Data Source=192.168.1.2\\SQL2008;uid=sa;pwd=123456a;database=xfzb;Connect Timeout=30").Encryptogram("jxkejixu");
            var decrypeStr = encrypeStr.Decryptogram("jxkejixu");
            var model = new TestModel() { Name = "test", Order = 1, IsFinish = true };
            var cpr = model.Compression();
            var obj = cpr.Decompress<TestModel>();
            WCFPorxy client = new WCFPorxy();
            Console.WriteLine("服务已启动");
            var str = "select * from t_class";
            var ss = client.ExecuteNoQuery(new WCFData { SqlText = "", Param = new Hashtable() });
            Console.WriteLine("返回为{0}", ss);
            client.Close();
            Console.WriteLine("服务已关闭");
            Console.ReadLine();
        }
    }
    public class WCFPorxy : WCFClient { }
    [Serializable]
    public class TestModel
    {
        public string Name { get; set; }
        public int Order { get; set; }
        public bool IsFinish { get; set; }
    }
}

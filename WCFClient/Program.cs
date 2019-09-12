using System;
using System.Collections;
using System.Data;
using System.Threading;
using TransparentAgent.BaseClient;
using TransparentAgent.Contract;
using TransparentAgent.Infrastructure;

namespace WCFClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WCFPorxy client = new WCFPorxy();
            Console.WriteLine("服务已启动");
            var str = "select top 20000 * from v_sell_report";
            var t1 = DateTime.Now;
            var ss = client.ExecuteReader(new ContractData {UserId = "1", SqlText = new string[1] { str } });
            var t2 = DateTime.Now;
            var result = (DataTable)ss.AppendData;
            
            //foreach (var row in result.Select())
            //{
            //    foreach (DataColumn item in result.Columns)
            //    {
            //        Console.Write(row[item.ColumnName].ToString());
            //    }
            //    //Thread.Sleep(200);
            //    Console.WriteLine();
            //}
            Console.WriteLine(ss.Message);
            Console.WriteLine("开始事件为：{0}，结束事件为：{1}", t1, t2);
            client.Close();
            Console.WriteLine("服务已关闭");
            Console.ReadLine();
        }
    }
    public class WCFPorxy : AgentClient { }
    [Serializable]
    public class TestModel
    {
        public string Name { get; set; }
        public int Order { get; set; }
        public bool IsFinish { get; set; }
    }
}

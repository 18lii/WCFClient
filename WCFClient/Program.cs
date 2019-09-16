using System;
using System.Collections;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
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
            var str = "select top 1000 * from t_item";
            DateTime t1Start;
            DateTime t1Finish;
            ////new Thread();
            //var th1 = new Thread(() =>
            //{
            //    t1Start = DateTime.Now;
            //    Console.WriteLine("任务1开始时间：{0}", t1Start.ToString());
            //    var ss = client.SelectAsync(new ContractData { SqlText = new string[1] { str }, Param = new Hashtable[1] { new Hashtable() }, sequence = true });
            //    var t2 = DateTime.Now;
            //    var result = client.Result(ss);
            //    t1Finish = DateTime.Now;
            //    Console.WriteLine("任务1结束时间：{0}", t1Finish.ToString());
            //});
            //DateTime t2Start;
            //DateTime t2Finish;
            //var th2 = new Thread(() =>
            //{
            //    t2Start = DateTime.Now;
            //    Console.WriteLine("任务2开始时间：{0}", t2Start.ToString());
            //    var ss = client.SelectAsync(new ContractData { SqlText = new string[1] { str }, Param = new Hashtable[1] { new Hashtable() }, sequence = true });
            //    var t2 = DateTime.Now;
            //    var result = client.Result(ss);
            //    t2Finish = DateTime.Now;
            //    Console.WriteLine("任务2结束时间：{0}", t2Finish.ToString());
            //});
            var max = 16;
            var tList = new Thread[max];
            var iList = new Tuple<int, object, DateTime>[max];
            var iSignal = new AutoResetEvent[max];
            var ids = new Guid[max];
            Console.ReadLine();
            Parallel.For(0, iSignal.Length, i =>
            {
                Thread.Sleep(i + 100);
                iSignal[i] = new AutoResetEvent(false);
                new Thread(() =>
                {
                    Console.WriteLine("任务{0}开始时间：{1}", i, DateTime.Now.ToString());
                    var ss = client.SelectAsync(new ContractData { SqlText = new string[1] { str }, Param = new Hashtable[1] { new Hashtable() }, sequence = true });
                    var t2 = DateTime.Now;
                    ids[i] = ss;
                    //iSignal[i].Set();
                })
                { IsBackground = true }.Start();
                //iSignal[i].WaitOne();
                
            });
            Thread.Sleep(2000);
            for(var i = 0; i < ids.Length; i++)
            {
                var result = client.Result(ids[i]);

                var tb = ((DataTable)result.AppendData);
                t1Finish = DateTime.Now;
                iList[i] = new Tuple<int, object, DateTime>(tb.Rows.Count, tb, t1Finish);
                Console.WriteLine("任务{0}结束时间：{1}， 共计：{2}条记录", i, iList[i].Item3, iList[i].Item1);
            }
            //var result = await client.Result(ss);
            //var tb = result.AppendData as DataTable;
            //foreach (var row in tb.Select())
            //{
            //    foreach (DataColumn item in tb.Columns)
            //    {
            //        Console.Write(row[item.ColumnName].ToString());
            //    }
            //    //Thread.Sleep(200);
            //    Console.WriteLine();
            //}
            ////Console.WriteLine(ss.Message);
            //Console.WriteLine("开始事件为：{0}，结束事件为：{1}", t1, t2);


            Console.ReadKey();
            client.Close();
            Console.WriteLine("服务已关闭，按任意键退出......");
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

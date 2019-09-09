using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            
            WCFClient client = new WCFClient();
            Console.WriteLine("服务已启动");
            var str = "select * from t_class";
            var ss = client.ExecuteNoQuery(Encoding.Default.GetBytes(str));
            Console.WriteLine("返回为{0}", ss);
            //var sss = client.Result(ss);
            client.Close();
            Console.WriteLine("服务已关闭");
            Console.ReadLine();
        }
    }
    public class WCFClient : ClientBase<IService>, IService
    {
        public WCFClient()
            : base()
        {

        }

        public WCFClient(System.ServiceModel.Channels.Binding binding, EndpointAddress remoteAddress)
            : base(binding, remoteAddress)
        {

        }

        public byte[] ExecuteNoQuery(byte[] value)
        {
            return base.Channel.ExecuteNoQuery(value);
        }

        public string GetData(int value)
        {
            return base.Channel.GetData(value);
        }
        
        public IGenericResult Result(Guid id)
        {
            throw new NotImplementedException();
        }
    }
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        byte[] ExecuteNoQuery(byte[] value);
        [OperationContract]
        IGenericResult Result(Guid id);
        [OperationContract]
        string GetData(int value);
    }
    public interface IGenericResult
    {
        /// <summary>
        ///  获取或设置操作结果类型
        /// </summary>
        ResultType ResultType { get; set; }

        /// <summary>
        ///  获取或设置操作返回信息
        /// </summary>
        string Message { get; set; }

        /// <summary>
        ///  获取或设置操作返回的日志消息，用于记录日志
        /// </summary>
        string LogMessage { get; set; }

        /// <summary>
        ///  获取或设置操作结果附加信息
        /// </summary>
        object AppendData { get; set; }
    }
    public interface IGenericResult<T>
    {
        /// <summary>
        ///  获取或设置操作结果类型
        /// </summary>
        ResultType ResultType { get; set; }

        /// <summary>
        ///  获取或设置操作返回信息
        /// </summary>
        string Message { get; set; }

        /// <summary>
        ///  获取或设置操作返回的日志消息，用于记录日志
        /// </summary>
        string LogMessage { get; set; }

        /// <summary>
        ///  获取或设置操作结果附加信息
        /// </summary>
        T Item { get; set; }
    }
    public enum ResultType
    {
        /// <summary>
        ///     操作成功
        /// </summary>
        Success,

        /// <summary>
        ///     操作取消或操作没引发任何变化
        /// </summary>
        NoChanged,

        /// <summary>
        ///     参数错误
        /// </summary>
        ParamError,

        /// <summary>
        ///     指定参数的数据不存在
        /// </summary>
        QueryNull,

        /// <summary>
        ///     权限不足
        /// </summary>
        PurviewLack,

        /// <summary>
        ///     非法操作
        /// </summary>
        IllegalOperation,

        /// <summary>
        ///     警告
        /// </summary>
        Warning,

        /// <summary>
        ///     操作引发错误
        /// </summary>
        Error
    }
}

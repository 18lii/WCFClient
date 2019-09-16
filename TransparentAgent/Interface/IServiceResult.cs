
namespace TransparentAgent.Interface
{
    public interface IServiceResult
    {
        /// <summary>
        ///  获取或设置操作结果类型
        /// </summary>
        bool ResultType { get; set; }

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
    public interface IServiceResult<T>
    {
        /// <summary>
        ///  获取或设置操作结果类型
        /// </summary>
        bool ResultType { get; set; }

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
}

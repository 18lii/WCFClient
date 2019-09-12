using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TransparentAgent.Infrastructure;
using TransparentAgent.Interface;

namespace TransparentAgent.Contract
{
    [Serializable]
    public class ServiceResult : IServiceResult
    {
        public ServiceResult() { }
        public ServiceResult(ResultType resultType)
        {
            ResultType = resultType;
        }

        public ServiceResult(ResultType resultType, object appendData)
            : this(resultType)
        {
            AppendData = appendData;
        }

        public ServiceResult(ResultType resultType, string logMessage)
            : this(resultType)
        {
            LogMessage = logMessage;
        }

        public ServiceResult(ResultType resultType, string logMessage, object appendData)
            : this(resultType, logMessage)
        {
            AppendData = appendData;
        }

        public ResultType ResultType { get; set; }
        public string Message { get; set; }
        public string LogMessage { get; set; }
        public object AppendData { get; set; }
    }
}

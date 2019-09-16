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
        public ServiceResult(bool resultType)
        {
            ResultType = resultType;
        }

        public ServiceResult(bool resultType, object appendData)
            : this(resultType)
        {
            AppendData = appendData;
        }

        public ServiceResult(bool resultType, string logMessage)
            : this(resultType)
        {
            LogMessage = logMessage;
        }

        public ServiceResult(bool resultType, string logMessage, object appendData)
            : this(resultType, logMessage)
        {
            AppendData = appendData;
        }

        public bool ResultType { get; set; }
        public string Message { get; set; }
        public string LogMessage { get; set; }
        public object AppendData { get; set; }
    }
}

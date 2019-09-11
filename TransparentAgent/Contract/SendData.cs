using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TransparentAgent.Contract
{
    [Serializable]
    [DataContract(Name = "ReceiveData", Namespace = ConfigurationManager.AppSettings.Get("endpoint"))]
    public class SendData
    {
        [DataMember(Order = 0)]
        public string UserId { get; set; }
        [DataMember(Order = 1)]
        public string SqlText { get; set; }
        [DataMember(Order = 2)]
        public Hashtable[] Param { get; set; }
        [DataMember(Order = 3)]
        public DataSet DataSet { get; set; }
    }
}

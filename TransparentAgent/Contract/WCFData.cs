using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TransparentAgent.Contract
{
    [DataContract]
    public class WCFData
    {
        [DataMember]
        public string SqlText { get; set; }
        [DataMember]
        public Hashtable Param { get; set; }
    }
}

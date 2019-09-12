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
    public class ContractData
    {
        public string UserId { get; set; }
        public string[] SqlText { get; set; }
        public Hashtable[] Param { get; set; }
        public DataSet[] DataSet { get; set; }
    }
}

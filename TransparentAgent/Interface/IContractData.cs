using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace TransparentAgent.Interface
{
    public interface IContractData
    {
        /// <summary>
        /// 契约数据类型接口
        /// </summary>
        string[] SqlText { get; set; }
        Hashtable[] Param { get; set; }
        DataSet[] DataSet { get; set; }
        bool sequence { get; set; }
    }
}

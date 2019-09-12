using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransparentAgent.Infrastructure
{
    public enum ResultType
    {
        /// <summary>
        ///     操作成功
        /// </summary>
        Success = 0,

        /// <summary>
        ///     操作取消或操作没引发任何变化
        /// </summary>
        NoChanged = 1,

        /// <summary>
        ///     参数错误
        /// </summary>
        ParamError = 2,

        /// <summary>
        ///     指定参数的数据不存在
        /// </summary>
        QueryNull = 3,

        /// <summary>
        ///     权限不足
        /// </summary>
        PurviewLack = 4,

        /// <summary>
        ///     非法操作
        /// </summary>
        IllegalOperation = 5,

        /// <summary>
        ///     警告
        /// </summary>
        Warning = 6,

        /// <summary>
        ///     操作引发错误
        /// </summary>
        Error = 7
    }
}

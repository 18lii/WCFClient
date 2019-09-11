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

using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TransparentAgent.Contract
{
    [ServiceContract]
    public interface IService
    {
        /// <summary>
        /// 查询方法，同步
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [OperationContract]
        byte[] Select(byte[] value);
        /// <summary>
        /// 查询方法，异步
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [OperationContract]
        byte[] SelectAsync(byte[] value);
        /// <summary>
        /// 插入方法，同步
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [OperationContract]
        byte[] Insert(byte[] value);
        /// <summary>
        /// 插入方法，异步
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [OperationContract]
        byte[] InsertAsync(byte[] value);
        /// <summary>
        /// 更新方法，同步
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [OperationContract]
        byte[] Update(byte[] value);
        /// <summary>
        /// 更新方法，异步
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [OperationContract]
        byte[] UpdateAsync(byte[] value);
        /// <summary>
        /// 删除方法，同步
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [OperationContract]
        byte[] Delete(byte[] value);
        /// <summary>
        /// 删除方法，异步
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [OperationContract]
        byte[] DeleteAsync(byte[] value);
        /// <summary>
        /// 无结果集数据操作，同步
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [OperationContract]
        byte[] ExecuteNoQuery(byte[] value);
        /// <summary>
        /// 无结果集数据操作，异步
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [OperationContract]
        byte[] ExecuteNoQueryAsync(byte[] value);
        /// <summary>
        /// 单结果查询，同步
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [OperationContract]
        byte[] ExecuteScalar(byte[] value);
        /// <summary>
        /// 单结果查询，异步
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [OperationContract]
        byte[] ExecuteScalarAsync(byte[] value);
        /// <summary>
        /// 有结果集数据操作，同步
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [OperationContract]
        byte[] ExecuteReader(byte[] value);
        /// <summary>
        /// 有结果集数据操作
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [OperationContract]
        byte[] ExecuteReaderAsync(byte[] value);
        /// <summary>
        /// 执行存储过程，同步
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [OperationContract]
        byte[] ExecuteProcedure(byte[] value);
        /// <summary>
        /// 执行存储过程，异步
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [OperationContract]
        byte[] ExecuteProcedureAsync(byte[] value);
        /// <summary>
        /// 有结果集数据适配器查询，同步
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [OperationContract]
        byte[] AdapterGet(byte[] value);
        /// <summary>
        /// 有结果集数据适配器查询，异步
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [OperationContract]
        byte[] AdapterGetAsync(byte[] value);
        /// <summary>
        /// 无结果集数据适配器操作，同步
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [OperationContract]
        byte[] AdapterSet(byte[] value);
        /// <summary>
        /// 无结果集数据适配器操作，异步
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [OperationContract]
        byte[] AdapterSetAsync(byte[] value);
        /// <summary>
        /// 获取异步操作结果，同步
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        byte[] Result(byte[] id);
    }
}

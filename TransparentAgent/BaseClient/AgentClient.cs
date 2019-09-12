using System;
using System.Data;
using System.Collections;
using System.ServiceModel;
using TransparentAgent.Contract;
using TransparentAgent.Infrastructure;
using TransparentAgent.Interface;

namespace TransparentAgent.BaseClient
{
    /// <summary>
    /// WCF透明代理类
    /// </summary>
    public abstract class AgentClient : ClientBase<IService>, IClientBase
    {
        public AgentClient() : base() { }

        public AgentClient(System.ServiceModel.Channels.Binding binding, EndpointAddress remoteAddress)
            : base(binding, remoteAddress) { }
        /// <summary>
        /// 同步方法，通过SQL语句与 <see cref="Hashtable"/>[] 参数进行数据查询
        /// 返回结果<see cref="object"/> <see cref="IServiceResult.AppendData"/> 为结果集，实际类型：<see cref="DataTable"/>
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public IServiceResult Select(ContractData data)
        {
            return Channel.Select(data.Compression()).Decompress<IServiceResult>();
        }
        /// <summary>
        /// 异步方法，通过SQL语句与 <see cref="Hashtable"/>[] 参数进行数据查询，
        /// 通过<see cref="AgentClient.Result(Guid)"/>取回异步执行结果，
        /// 返回结果<see cref="object"/> <see cref="IServiceResult.AppendData"/> 为受影响行数，实际类型：<see cref="DataTable"/>
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public IServiceResult SelectAsync(ContractData data)
        {
            return Channel.SelectAsync(data.Compression()).Decompress<IServiceResult>();
        }
        /// <summary>
        /// 同步方法，通过SQL语句与 <see cref="Hashtable"/>[] 参数进行数据插入，
        /// 返回结果<see cref="object"/> <see cref="IServiceResult.AppendData"/> 为受影响行数，实际类型：<see cref="int"/>
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public IServiceResult Insert(ContractData data)
        {
            return Channel.Insert(data.Compression()).Decompress<IServiceResult>();
        }
        /// <summary>
        /// 异步方法，通过SQL语句与 <see cref="Hashtable"/>[] 参数进行数据插入，
        /// 通过<see cref="AgentClient.Result(Guid)"/>取回异步执行结果，
        /// 返回结果<see cref="object"/> <see cref="IServiceResult.AppendData"/> 为受影响行数，实际类型：<see cref="int"/>
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public IServiceResult InsertAsync(ContractData data)
        {
            return Channel.InsertAsync(data.Compression()).Decompress<IServiceResult>();
        }
        /// <summary>
        /// 同步方法，通过SQL语句与 <see cref="Hashtable"/>[] 参数进行数据更新，SQL文无where部分将导致操作失败，
        /// 返回结果<see cref="object"/> <see cref="IServiceResult.AppendData"/> 为受影响行数，实际类型：<see cref="int"/>
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public IServiceResult Update(ContractData data)
        {
            return Channel.Update(data.Compression()).Decompress<IServiceResult>();
        }
        /// <summary>
        /// 异步方法，通过SQL语句与 <see cref="Hashtable"/>[] 参数进行数据更新，SQL文无where部分将导致操作失败，
        /// 通过<see cref="AgentClient.Result(Guid)"/>取回异步执行结果，
        /// 返回结果<see cref="object"/> <see cref="IServiceResult.AppendData"/> 为受影响行数，实际类型：<see cref="int"/>
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public IServiceResult UpdateAsync(ContractData data)
        {
            return Channel.UpdateAsync(data.Compression()).Decompress<IServiceResult>();
        }
        /// <summary>
        /// 同步方法，通过SQL语句与 <see cref="Hashtable"/>[] 参数进行数据删除，SQL文无where部分将导致操作失败，
        /// 返回结果<see cref="object"/> <see cref="IServiceResult.AppendData"/> 为受影响行数，实际类型：<see cref="int"/>
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public IServiceResult Delete(ContractData data)
        {
            return Channel.Delete(data.Compression()).Decompress<IServiceResult>();
        }
        /// <summary>
        /// 异步方法，通过SQL语句与 <see cref="Hashtable"/>[] 参数进行数据删除，SQL文无where部分将导致操作失败，
        /// 通过<see cref="AgentClient.Result(Guid)"/>取回异步执行结果，
        /// 返回结果<see cref="object"/> <see cref="IServiceResult.AppendData"/> 为受影响行数，实际类型：<see cref="int"/>
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public IServiceResult DeleteAsync(ContractData data)
        {
            return Channel.DeleteAsync(data.Compression()).Decompress<IServiceResult>();
        }
        /// <summary>
        /// 同步方法，通过SQL语句进行数据查询，
        /// 返回结果<see cref="object"/> <see cref="IServiceResult.AppendData"/> 为结果集，实际类型：<see cref="DataTable"/>
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public IServiceResult ExecuteReader(ContractData data)
        {
            return Channel.ExecuteReader(data.Compression()).Decompress<IServiceResult>();
        }
        /// <summary>
        /// 异步方法，通过SQL语句进行数据查询，
        /// 通过<see cref="AgentClient.Result(Guid)"/>取回异步执行结果，
        /// 返回结果<see cref="object"/> <see cref="IServiceResult.AppendData"/> 为结果集，实际类型：<see cref="DataTable"/>
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public IServiceResult ExecuteReaderAsync(ContractData data)
        {
            return Channel.ExecuteReaderAsync(data.Compression()).Decompress<IServiceResult>();
        }
        /// <summary>
        /// 同步方法，通过SQL语句进行数据查询，
        /// 返回结果<see cref="object"/> <see cref="IServiceResult.AppendData"/> 为查询结果的第一行第一列的值，实际类型：数据库实际存储类型
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public IServiceResult ExecuteScalar(ContractData data)
        {
            return Channel.ExecuteScalar(data.Compression()).Decompress<IServiceResult>();
        }
        /// <summary>
        /// 异步方法，通过SQL语句进行数据查询，
        /// 通过<see cref="AgentClient.Result(Guid)"/>取回异步执行结果，
        /// 返回结果<see cref="object"/> <see cref="IServiceResult.AppendData"/> 为查询结果的第一行第一列的值，实际类型：数据库实际存储类型
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public IServiceResult ExecuteScalarAsync(ContractData data)
        {
            return Channel.ExecuteScalarAsync(data.Compression()).Decompress<IServiceResult>();
        }
        /// <summary>
        /// 同步方法，通过SQL语句进行数据操作，
        /// 返回结果<see cref="object"/> <see cref="IServiceResult.AppendData"/> 为受影响行数，实际类型：<see cref="int"/>
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public IServiceResult ExecuteNoQuery(ContractData data)
        {
            return Channel.ExecuteNoQuery(data.Compression()).Decompress<IServiceResult>();
        }
        /// <summary>
        /// 异步方法，通过SQL语句进行数据操作，
        /// 通过<see cref="AgentClient.Result(Guid)"/>取回异步执行结果，
        /// 返回结果<see cref="object"/> <see cref="IServiceResult.AppendData"/> 为受影响行数，实际类型：<see cref="int"/>
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public IServiceResult ExecuteNoQueryAsync(ContractData data)
        {
            return Channel.ExecuteNoQueryAsync(data.Compression()).Decompress<IServiceResult>();
        }
        /// <summary>
        /// 同步方法，通过存储过程名称与 <see cref="Hashtable"/>[] 执行存储过程，
        /// 返回结果<see cref="object"/> <see cref="IServiceResult.AppendData"/> ，实际类型：存储过程实际返回类型
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public IServiceResult ExecuteProcedure(ContractData data)
        {
            return Channel.ExecuteProcedure(data.Compression()).Decompress<IServiceResult>();
        }
        /// <summary>
        /// 异步方法，通过存储过程名称与 <see cref="Hashtable"/>[] 执行存储过程，
        /// 通过<see cref="AgentClient.Result(Guid)"/>取回异步执行结果，
        /// 返回结果<see cref="object"/> <see cref="IServiceResult.AppendData"/> ，实际类型：存储过程实际返回类型
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public IServiceResult ExecuteProcedureAsync(ContractData data)
        {
            return Channel.ExecuteProcedureAsync(data.Compression()).Decompress<IServiceResult>();
        }
        /// <summary>
        /// 同步方法，通过SQL语句与数据适配器进行查询，返回结果集，
        /// 返回结果<see cref="object"/> <see cref="IServiceResult.AppendData"/> ，实际类型：<see cref="DataTable"/> 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public IServiceResult AdapterGet(ContractData data)
        {
            return Channel.AdapterGet(data.Compression()).Decompress<IServiceResult>();
        }
        /// <summary>
        /// 异步方法，通过SQL语句与数据适配器进行查询，返回结果集，
        /// 通过<see cref="AgentClient.Result(Guid)"/>取回异步执行结果，
        /// 返回结果<see cref="object"/> <see cref="IServiceResult.AppendData"/> ，实际类型：<see cref="DataTable"/> 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public IServiceResult AdapterGetAsync(ContractData data)
        {
            return Channel.AdapterGet(data.Compression()).Decompress<IServiceResult>();
        }
        /// <summary>
        /// 同步方法，通过SQL语句、<see cref="DataSet"/>与数据适配器进行操作，返回受影响的行数，
        /// 返回结果<see cref="object"/> <see cref="IServiceResult.AppendData"/> ，实际类型：存储过程实际返回类型
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public IServiceResult AdapterSet(ContractData data)
        {
            return Channel.AdapterSet(data.Compression()).Decompress<IServiceResult>();
        }
        /// <summary>
        /// 异步方法，通过SQL语句、<see cref="DataSet"/>与数据适配器进行操作，返回受影响的行数，
        /// 通过<see cref="AgentClient.Result(Guid)"/>取回异步执行结果，
        /// 返回结果<see cref="object"/> <see cref="IServiceResult.AppendData"/> ，实际类型：<see cref="int"/> 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public IServiceResult AdapterSetAsync(ContractData data)
        {
            return Channel.AdapterSet(data.Compression()).Decompress<IServiceResult>();
        }
        /// <summary>
        /// 通过<see cref="Guid"/>获取异步操作结果，需等待
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IServiceResult Result(Guid id)
        {
            return Channel.Delete(id.Compression()).Decompress<IServiceResult>();
        }
    }
}

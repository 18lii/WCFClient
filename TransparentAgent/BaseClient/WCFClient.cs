using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using TransparentAgent.Contract;
using TransparentAgent.Infrastructure;
using TransparentAgent.Interface;

namespace TransparentAgent.BaseClient
{
    /// <summary>
    /// WCF透明代理类
    /// </summary>
    public abstract class WCFClient : ClientBase<IService>, IClientBase
    {
        public WCFClient() : base() { }

        public WCFClient(System.ServiceModel.Channels.Binding binding, EndpointAddress remoteAddress)
            : base(binding, remoteAddress) { }
        public IGenericResult Select(WCFData data)
        {
            return Channel.Select(data.Compression()).Decompress<IGenericResult>();
        }
        public IGenericResult SelectAsync(WCFData data)
        {
            return Channel.SelectAsync(data.Compression()).Decompress<IGenericResult>();
        }

        public IGenericResult Insert(WCFData data)
        {
            return Channel.Insert(data.Compression()).Decompress<IGenericResult>();
        }
        public IGenericResult InsertAsync(WCFData data)
        {
            return Channel.InsertAsync(data.Compression()).Decompress<IGenericResult>();
        }
        public IGenericResult Update(WCFData data)
        {
            return Channel.Update(data.Compression()).Decompress<IGenericResult>();
        }
        public IGenericResult UpdateAsync(WCFData data)
        {
            return Channel.UpdateAsync(data.Compression()).Decompress<IGenericResult>();
        }
        public IGenericResult Delete(WCFData data)
        {
            return Channel.Delete(data.Compression()).Decompress<IGenericResult>();
        }
        public IGenericResult DeleteAsync(WCFData data)
        {
            return Channel.DeleteAsync(data.Compression()).Decompress<IGenericResult>();
        }
        public IGenericResult ExecuteReader(WCFData data)
        {
            return Channel.ExecuteReader(data.Compression()).Decompress<IGenericResult>();
        }
        public IGenericResult ExecuteReaderAsync(WCFData data)
        {
            return Channel.ExecuteReaderAsync(data.Compression()).Decompress<IGenericResult>();
        }
        public IGenericResult ExecuteScalar(WCFData data)
        {
            return Channel.ExecuteScalar(data.Compression()).Decompress<IGenericResult>();
        }
        public IGenericResult ExecuteScalarAsync(WCFData data)
        {
            return Channel.ExecuteScalarAsync(data.Compression()).Decompress<IGenericResult>();
        }
        public IGenericResult ExecuteNoQuery(WCFData data)
        {
            return Channel.ExecuteNoQuery(data.Compression()).Decompress<IGenericResult>();
        }
        public IGenericResult ExecuteNoQueryAsync(WCFData data)
        {
            return Channel.ExecuteNoQueryAsync(data.Compression()).Decompress<IGenericResult>();
        }
        public IGenericResult ExecuteProcedure(WCFData data)
        {
            return Channel.ExecuteProcedure(data.Compression()).Decompress<IGenericResult>();
        }
        public IGenericResult ExecuteProcedureAsync(WCFData data)
        {
            return Channel.ExecuteProcedureAsync(data.Compression()).Decompress<IGenericResult>();
        }
        public IGenericResult Result(Guid id)
        {
            return Channel.Delete(id.Compression()).Decompress<IGenericResult>();
        }
    }
}

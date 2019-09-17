using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransparentAgent.Contract;

namespace TransparentAgent.Interface
{
    public interface IClientBase
    {
        IServiceResult Select(IContractData data);
        Guid SelectAsync(IContractData data);
        IServiceResult Insert(IContractData data);
        Guid InsertAsync(IContractData data);
        IServiceResult Update(IContractData data);
        Guid UpdateAsync(IContractData data);
        IServiceResult Delete(IContractData data);
        Guid DeleteAsync(IContractData data);
        IServiceResult ExecuteNoQuery(IContractData data);
        Guid ExecuteNoQueryAsync(IContractData data);
        IServiceResult ExecuteScalar(IContractData data);
        Guid ExecuteScalarAsync(IContractData data);
        IServiceResult ExecuteReader(IContractData data);
        Guid ExecuteReaderAsync(IContractData data);
        IServiceResult ExecuteProcedure(IContractData data);
        Guid ExecuteProcedureAsync(IContractData data);
        IServiceResult AdapterGet(IContractData data);
        Guid AdapterGetAsync(IContractData data);
        IServiceResult AdapterSet(IContractData data);
        Guid AdapterSetAsync(IContractData data);
        void Result(Guid id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TransparentAgent.Contract;

namespace TransparentAgent.Interface
{
    public interface IClientBase
    {
        IServiceResult Select(ContractData data);
        IServiceResult SelectAsync(ContractData data);
        IServiceResult Insert(ContractData data);
        IServiceResult InsertAsync(ContractData data);
        IServiceResult Update(ContractData data);
        IServiceResult UpdateAsync(ContractData data);
        IServiceResult Delete(ContractData data);
        IServiceResult DeleteAsync(ContractData data);
        IServiceResult ExecuteNoQuery(ContractData data);
        IServiceResult ExecuteNoQueryAsync(ContractData data);
        IServiceResult ExecuteScalar(ContractData data);
        IServiceResult ExecuteScalarAsync(ContractData data);
        IServiceResult ExecuteReader(ContractData data);
        IServiceResult ExecuteReaderAsync(ContractData data);
        IServiceResult ExecuteProcedure(ContractData data);
        IServiceResult ExecuteProcedureAsync(ContractData data);
        IServiceResult AdapterGet(ContractData data);
        IServiceResult AdapterGetAsync(ContractData data);
        IServiceResult AdapterSet(ContractData data);
        IServiceResult AdapterSetAsync(ContractData data);
        IServiceResult Result(Guid id);
    }
}

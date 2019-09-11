using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TransparentAgent.Contract;

namespace TransparentAgent.Interface
{
    public interface IClientBase
    {
        IGenericResult Select(SendData data);
        IGenericResult SelectAsync(SendData data);
        IGenericResult Insert(SendData data);
        IGenericResult InsertAsync(SendData data);
        IGenericResult Update(SendData data);
        IGenericResult UpdateAsync(SendData data);
        IGenericResult Delete(SendData data);
        IGenericResult DeleteAsync(SendData data);
        IGenericResult ExecuteNoQuery(SendData data);
        IGenericResult ExecuteNoQueryAsync(SendData data);
        IGenericResult ExecuteScalar(SendData data);
        IGenericResult ExecuteScalarAsync(SendData data);
        IGenericResult ExecuteReader(SendData data);
        IGenericResult ExecuteReaderAsync(SendData data);
        IGenericResult ExecuteProcedure(SendData data);
        IGenericResult ExecuteProcedureAsync(SendData data);
        IGenericResult AdapterGet(SendData data);
        IGenericResult AdapterGetAsync(SendData data);
        IGenericResult AdapterSet(SendData data);
        IGenericResult AdapterSetAsync(SendData data);
        IGenericResult Result(Guid id);
    }
}

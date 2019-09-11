using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TransparentAgent.Contract;

namespace TransparentAgent.Interface
{
    public interface IClientBase
    {
        IGenericResult Select(WCFData data);
        IGenericResult SelectAsync(WCFData data);
        IGenericResult Insert(WCFData data);
        IGenericResult InsertAsync(WCFData data);
        IGenericResult Update(WCFData data);
        IGenericResult UpdateAsync(WCFData data);
        IGenericResult Delete(WCFData data);
        IGenericResult DeleteAsync(WCFData data);
        IGenericResult ExecuteNoQuery(WCFData data);
        IGenericResult ExecuteNoQueryAsync(WCFData data);
        IGenericResult ExecuteScalar(WCFData data);
        IGenericResult ExecuteScalarAsync(WCFData data);
        IGenericResult ExecuteReader(WCFData data);
        IGenericResult ExecuteReaderAsync(WCFData data);
        IGenericResult ExecuteProcedure(WCFData data);
        IGenericResult ExecuteProcedureAsync(WCFData data);
        IGenericResult Result(Guid id);
    }
}

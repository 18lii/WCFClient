﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace TransparentAgent.Contract
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        byte[] Select(byte[] value);
        [OperationContract]
        byte[] SelectAsync(byte[] value);
        [OperationContract]
        byte[] Insert(byte[] value);
        [OperationContract]
        byte[] InsertAsync(byte[] value);
        [OperationContract]
        byte[] Update(byte[] value);
        [OperationContract]
        byte[] UpdateAsync(byte[] value);
        [OperationContract]
        byte[] Delete(byte[] value);
        [OperationContract]
        byte[] DeleteAsync(byte[] value);
        [OperationContract]
        byte[] ExecuteNoQuery(byte[] value);
        [OperationContract]
        byte[] ExecuteNoQueryAsync(byte[] value);
        [OperationContract]
        byte[] ExecuteScalar(byte[] value);
        [OperationContract]
        byte[] ExecuteScalarAsync(byte[] value);
        [OperationContract]
        byte[] ExecuteReader(byte[] value);
        [OperationContract]
        byte[] ExecuteReaderAsync(byte[] value);
        [OperationContract]
        byte[] ExecuteProcedure(byte[] value);
        [OperationContract]
        byte[] ExecuteProcedureAsync(byte[] value);
        [OperationContract]
        byte[] Result(byte[] id);
    }
}

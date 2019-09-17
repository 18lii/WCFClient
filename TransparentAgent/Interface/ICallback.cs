using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransparentAgent.Interface
{
    public interface ICallback
    {
        void Result(Guid id, AsyncCallback callback);
    }
}

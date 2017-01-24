using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceProject
{
    [ServiceContract]
    public interface ISomeService
    {
        [OperationContract]
        void DoWork();
    }
}

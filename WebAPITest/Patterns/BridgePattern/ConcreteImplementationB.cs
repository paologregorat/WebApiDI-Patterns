using System;
using System.Collections.Generic;
using System.Text;

namespace TestEFPostgres.Entities.BridgePattern
{
    public class ConcreteImplementationB : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationA: The result in platform B.\n";
        }
    }
}

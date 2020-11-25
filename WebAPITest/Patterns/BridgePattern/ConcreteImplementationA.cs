using System;
using System.Collections.Generic;
using System.Text;

namespace TestEFPostgres.Entities.BridgePattern
{
    public class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationA: The result in platform A.\n";
        }
    }
}

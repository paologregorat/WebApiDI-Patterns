using System;
using System.Collections.Generic;
using System.Text;

namespace TestEFPostgres.Entities.BridgePattern
{
    public class Abstraction
    {
        protected IImplementation _implementation;

        public Abstraction(IImplementation implementation)
        {
            this._implementation = implementation;
        }

        public virtual string Operation()
        {
            return "Abstract: Base operation with:\n" +
                   _implementation.OperationImplementation();
        }
    }
}

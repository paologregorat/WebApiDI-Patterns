using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Console;
using NodaTime;
using WebAPITest.Commands.Abstract;

namespace WebAPITest.Commands.Concrete
{
    public class MyDependency : IMyDependency
    {

        public MyDependency()
        {
  
        }
        
        public void WriteLog()
        {
            Console.WriteLine();
        }

        
    }
}

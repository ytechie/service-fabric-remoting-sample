using Microsoft.ServiceFabric.Services.Remoting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerService
{
    public interface IEchoService : IService
    {
        Task<string> Echo(string echo);
    }
}

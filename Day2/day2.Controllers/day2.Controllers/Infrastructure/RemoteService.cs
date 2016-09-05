using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace day2.Controllers.Infrastructure
{
    public class RemoteService
    {
        public async Task<string> GetRemoteData()
        {
            Thread.Sleep(2000);
            return await Task<string>.Factory.StartNew(() =>
            {

            })
        }
    }
}
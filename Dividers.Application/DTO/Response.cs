using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dividers.Application.DTO
{
    public class Response
    {
        public object Result { get; private set; }
        public string Message { get; private set; }

        public Task<Response> Generate(object result = default, string message = default)
        {
            this.Result = result;
            this.Message = message;
            return Task.FromResult(this);
        }
    }
}

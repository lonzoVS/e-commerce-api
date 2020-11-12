using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace skinet.Errors
{
    public class ApiValidationsErrorResponse : ApiResponse
    {
        public ApiValidationsErrorResponse() : base(400)
        {

        }

        public IEnumerable<string> Errors { get; set; }

    }
}

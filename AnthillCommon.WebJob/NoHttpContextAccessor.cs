using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthillCommon.WebJob
{
    public class NoHttpContextAccessor : IHttpContextAccessor
    {
        public HttpContext HttpContext { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }
    }
}

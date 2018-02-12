using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Shared;

namespace MyClient
{
    public class HttpUserContext : IUserContext
    {
        private readonly HttpContext context;

        public HttpUserContext(IHttpContextAccessor contextAccessor)
        {
            this.context = contextAccessor.HttpContext;
        }
        
        public string UserName { get => context.User?.Identity?.Name; set => throw new NotImplementedException(); }
    }
}

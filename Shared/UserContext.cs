using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public class UserContext : IUserContext
    {
        public int UserId { get; set; }

        public string UserName { get; set; }
    }
}

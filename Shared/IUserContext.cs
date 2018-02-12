using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public interface IUserContext
    {
        int UserId { get; set; }

        string UserName { get; set; }
    }
}

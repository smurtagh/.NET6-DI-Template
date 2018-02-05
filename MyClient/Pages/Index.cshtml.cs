using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyManager;
using Shared;

namespace MyClient.Pages
{
    public class IndexModel : PageModel
    {
        private UserContext userContext = new UserContext();
        public string TestMeResult { get; set; }

        public void OnGet()
        {
            userContext.UserId = new Random().Next();
            TestMeResult = new ManagerServiceProvider(userContext).GetService<IMyManager>()
                .TestMe(Guid.NewGuid().ToString());
        }
    }
}

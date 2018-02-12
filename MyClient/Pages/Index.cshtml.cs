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
        private Shared.IServiceProvider managerServiceProvider;

        public string TestMeResult { get; set; }

        public IndexModel(Shared.IServiceProvider serviceProvider)
        {
            managerServiceProvider = serviceProvider;
        }

        public void OnGet()
        {
            TestMeResult = managerServiceProvider.GetService<IMyManager>()
                .TestMe(Guid.NewGuid().ToString());
        }
    }
}

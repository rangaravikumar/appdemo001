using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appdemo001.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration _config;

        public string name = "This is from cs";
        public IndexModel(ILogger<IndexModel> logger ,IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        public void OnGet()
        {
            name= _config.GetConnectionString("dbConn");


        }
       
    }
}

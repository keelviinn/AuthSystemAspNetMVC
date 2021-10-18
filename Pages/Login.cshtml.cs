using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetAuthPim.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetAuthPim.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Login Model { get; set; }
        public void OnGet()
        {
        }
    }
}

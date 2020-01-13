using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WerkbonApplicatie.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace WerkbonApplicatie.Pages
{
    public class IndexModel : PageModel
    {


        private readonly WerkbonApplicatie.Data.WerkbonApplicatieContext _context;

        public IndexModel(WerkbonApplicatie.Data.WerkbonApplicatieContext context)
        {
            _context = context;
        }

        public IList<Personeel> Personeel { get; set; }

        public async Task OnGetAsync()
        {
            Personeel = await _context.Personeel.ToListAsync();
        }

        [BindProperty]
        public string selectedFilter { get; set; }

        //------------------------------------------------------------------
        public const string SessionKeyName = "_Name";
        public const string Session = "Name";
        public string SessionInfo_Name { get; private set; }
        public void OnPost()
        {
            // Requires: using Microsoft.AspNetCore.Http;
            if (string.IsNullOrEmpty(HttpContext.Session.GetString(SessionKeyName)))
            {
                HttpContext.Session.SetString(SessionKeyName,"test");

            }
            var name = HttpContext.Session.GetString(SessionKeyName);
        }
        protected void btnSendData_Click(object sender, EventArgs e)
        {
            //Session["Name"] = txtName.Text;
            //Response.Redirect("Homepage.cshtml");
        }
    }
}
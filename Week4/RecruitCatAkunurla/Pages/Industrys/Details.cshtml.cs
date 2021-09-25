using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatAkunurla.Data;
using RecruitCatAkunurla.Models;

namespace RecruitCatAkunurla.Pages.Industrys
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatAkunurla.Data.RecruitCatAkunurlaContext _context;

        public DetailsModel(RecruitCatAkunurla.Data.RecruitCatAkunurlaContext context)
        {
            _context = context;
        }

        public Industry Industry { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Industry = await _context.Industry.FirstOrDefaultAsync(m => m.ID == id);

            if (Industry == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

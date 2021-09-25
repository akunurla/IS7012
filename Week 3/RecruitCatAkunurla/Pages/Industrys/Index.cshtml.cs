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
    public class IndexModel : PageModel
    {
        private readonly RecruitCatAkunurla.Data.RecruitCatAkunurlaContext _context;

        public IndexModel(RecruitCatAkunurla.Data.RecruitCatAkunurlaContext context)
        {
            _context = context;
        }

        public IList<Industry> Industry { get;set; }

        public async Task OnGetAsync()
        {
            Industry = await _context.Industry.ToListAsync();
        }
    }
}

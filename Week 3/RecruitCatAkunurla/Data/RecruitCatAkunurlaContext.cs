using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatAkunurla.Models;

namespace RecruitCatAkunurla.Data
{
    public class RecruitCatAkunurlaContext : DbContext
    {
        public RecruitCatAkunurlaContext (DbContextOptions<RecruitCatAkunurlaContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatAkunurla.Models.Candidate> Candidate { get; set; }
    }
}

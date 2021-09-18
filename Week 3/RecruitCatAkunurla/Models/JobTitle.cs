using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatAkunurla.Models
{
    public class JobTitle
    {
        public int Id { get; set; }
        public int MinimumExperience { get; set; }
        public decimal MiniSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public string Title { get; set; }
        public List<Candidate> Candidates { get; set; }
        public int CandidatesId { get; set; }

    }
}

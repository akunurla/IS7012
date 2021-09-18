using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatAkunurla.Models
{
    public class Industry
    {
        public string Name { get; set; }
        public int ID { get; set; } 
        public string ServiceDomain { get; set; }
        public List<Candidate> Candidates { get; set; }
        public int CandidatesId { get; set; }
        public List<Company> Companies { get; set; }
        public int CompaniesId { get; set; }

    }
}

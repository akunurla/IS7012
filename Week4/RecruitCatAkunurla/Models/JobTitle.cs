using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

using System.ComponentModel.DataAnnotations;

namespace RecruitCatAkunurla.Models
{
    public class JobTitle
    {
        public int Id { get; set; }
        [DisplayName("Minimum Experience")]
        public int MinimumExperience { get; set; }
        [DisplayName("Minimum Salary")]
        public decimal MiniSalary { get; set; }
        [DisplayName("Maximum Salary")]
        public decimal MaxSalary { get; set; }
        [DisplayName("Job Title")]
        public string Title { get; set; }
        public List<Candidate> Candidates { get; set; }
       

    }
}

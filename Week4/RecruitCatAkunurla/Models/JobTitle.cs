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
        [Range(0, 1000)]
        public decimal MiniSalary { get; set; }

        [DisplayName("Maximum Salary")]
        [Range(0, 10000)]
        public decimal MaxSalary { get; set; }
        [DisplayName("Job Title")]
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        public List<Candidate> Candidates { get; set; }
       

    }
}

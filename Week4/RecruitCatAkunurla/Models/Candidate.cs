using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace RecruitCatAkunurla.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        
        public DateTime DateOfBirth { get; set; }
        [DisplayName("Target Salary")]
        public decimal TargetSalary { get; set; }
        [DisplayName("Optional Start Date")]
        [DataType(DataType.Date)]
        
        public DateTime OptionalStartDate { get; set; }
        [DisplayName("First Name")]
        [Required]
        public string FirstName { get; set; }
      
        [DisplayName("Last Name")]
        [Required]

        public string LastName { get; set; }
        [DisplayName("Previous Work Experience")]
        public string? PreviousWorkExperience { get; set; }
        [DisplayName("Local Nationality")]
        public bool LocalNationality { get; set; }
        [DisplayName("Previous Salary")]

        public decimal PreviousSalary { get; set; }
       
        public Company Company { get; set; }
        [DisplayName("Company ID")]
        public int? CompanyId { get; set; }
        public JobTitle JobTitle { get; set; }
        [DisplayName("Job Title ID")]
        public int JobTitleId { get; set; }
        public Industry Industry { get; set; }
        [DisplayName("Industry ID")]
        public int IndustryId { get; set; }

    }
}

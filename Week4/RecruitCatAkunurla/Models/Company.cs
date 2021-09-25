using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace RecruitCatAkunurla.Models
{
    public class Company
    {
        public int Id { get; set; }

        [DisplayName("Name")]
        [Required]
        [StringLength(50)]

        public string Name { get; set; }
        [DisplayName("Location")]
    
        public string Location { get; set; }
        [DisplayName("Start Date")]
                [DataType(DataType.Date)]
        public DateTime OptionalStartDate { get; set; }
        [DisplayName("Minimum Salary")]
        public decimal MiniSalary { get; set; }
        [DisplayName("Maximum Salary")]
        public decimal MaxSalary { get; set; }
        [DisplayName("International Travel Availability")]
        public bool InternationalTravelAvailable { get; set; }
        [DisplayName("Position Offered")]
        public string PositionName { get; set; }
        [DisplayName("Established On")]
        [DataType(DataType.Date)]
        public DateTime EstablishedOn { get; set; }
       
        public List<Candidate> Candidates { get; set; }
       
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }
        public JobTitle Jobtitle { get; set; }
        public int JobtitleId { get; set; }

    }
}

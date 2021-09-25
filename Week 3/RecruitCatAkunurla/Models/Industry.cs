using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatAkunurla.Models
{
    public class Industry
    {
        [DisplayName("Name")]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [DisplayName("Industry ID")]
        public int ID { get; set; }
        [DisplayName("Profit Percent")]
        [Range(0, 100)]
        public int ProfitPercent { get; set; }
        
        public List<Candidate> Candidates { get; set; }
      
        public List<Company> Companys { get; set; }
       

    }
}

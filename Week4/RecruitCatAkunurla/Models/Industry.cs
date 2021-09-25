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
        public string Name { get; set; }
        [DisplayName("ID")]
        public int ID { get; set; }
        [DisplayName("Profit Percent")]
        public int ProfitPercent { get; set; }
        
        public List<Candidate> Candidates { get; set; }
      
        public List<Company> Companies { get; set; }
       

    }
}

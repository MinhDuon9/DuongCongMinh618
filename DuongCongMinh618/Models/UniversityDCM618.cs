using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DuongCongMinh618.Models
{
    public class UniversityDCM618
    {
        [Key]
        public int UniversityId { get; set; }
        public string UniversityName { get; set; }
    }
}

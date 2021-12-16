using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DuongCongMinh618.Models
{
    public class UniversityDCM618
    {
        [Key]
        [DisplayName("Mã định danh")]
        public int UniversityId { get; set; }
        [DisplayName("Tên trường")]
        public string UniversityName { get; set; }
    }
}

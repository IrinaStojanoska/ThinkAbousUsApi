using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ThinkAboutApi.Models
{
    public class HomelessDogsDetails
    {
        [Key]
        public int code { get; set; }
        [Required]
        [Column(TypeName="varchar(15)")]
        public bool status { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string size { get; set; }
        [Required]
        public bool gender { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string location { get; set; }
        [Required]
        public string breed { get; set; }
        public string description { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMigrations.Domain
{
    //Composite Key Example
    public class Passport
    {
        [Key]
        [Column(Order =1)]
        public int PassportNumber { get; set; }
        [Key]
        [Column (Order =2)]
        public string IssuingCountry { get; set; }
        public DateTime Issued { get; set; }
        public DateTime Expires { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Composite key forign key example
namespace EFCoreMigrations.Domain
{
    internal class PassportStamp
    {
        [Key]
        public int StampId { get; set; }
        public DateTime Stamped { get; set; }
        public string StampingCountry { get; set; }

        [ForeignKey("Passport")]
        [Column(Order =1)]
        public int PassportNo { get; set; }

        [ForeignKey("Passport")]
        [Column(Order =2)]
        public string IssuingCountry { get; set;}
        public Passport Passport {  get; set; }
    }
}

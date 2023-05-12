using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLibraryDataAccess.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName ="varchar(100)")]
        public string LastName { get; set; }
        [Required]
        [MaxLength(50)]
        
        public int age { get; set; }

        public List<Address> Addresses { get; set;} = new List<Address>();

        public List<Email> Emails { get; set; } = new List<Email>();
    }
}

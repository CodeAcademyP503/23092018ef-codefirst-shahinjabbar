using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankapp.Models
{
    [Table(name: "Customers", Schema = "BankApp")]
    public class Customer
    {
        public Customer()
        {
            Credits = new HashSet<Credit>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 5, ErrorMessage = "Name must be between 5 and 50 symbols!!!")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 5, ErrorMessage = "Surname must be between 5 and 50 symbols!!!")]
        public string Surname { get; set; }

        [Required]
        [Index(IsUnique = true)]
        public int PassportNumber { get; set; }

        public ICollection<Credit> Credits { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankapp.Models
{
    [Table(name: "Credits", Schema = "BankApp")]
    public class Credit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime GivenDate { get; set; }

        public Customer Customer { get; set; }

        [Required]
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
    }
}

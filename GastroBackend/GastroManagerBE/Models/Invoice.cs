using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GastroManagerBE.Models
{
    public class Invoice : Auditory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int InvoiceId { get; set; }
        public float PriceProduct { get; set; }
        public int OrderCustomerId { get; set; }
        public int ProductId { get; set; }

        [ForeignKey("OrderCustomerId")]
        public virtual OrderCustomer OrderCustomer { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}

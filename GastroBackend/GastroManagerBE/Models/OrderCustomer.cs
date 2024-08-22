using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GastroManagerBE.Models
{
    public class OrderCustomer : Auditory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int OrderCustomerId { get; set; }
        public int Amount { get; set; }
        public DateTime OrderTime { get; set; }
        public int CustomerId { get; set; }
        public int TableRestaurantId { get; set; }

        // Relaciónes
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        [ForeignKey("TableRestaurantId")]
        public virtual TableRestaurant TableRestaurant { get; set; }
    }
}

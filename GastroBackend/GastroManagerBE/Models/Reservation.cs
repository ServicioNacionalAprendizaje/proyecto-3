using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GastroManagerBE.Models
{
    public class Reservation : Auditory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ReservationId { get; set; }
        public string NameCustomer { get; set; }
        public string NumberGuest { get; set; }
        public string PhoneCustomer { get; set; }
        public DateTime ReservationDate { get; set; }
        public int CustomerId { get; set; }
        public int RestaurantId { get; set; }

        // Relación con Customer
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        // Relación con TableRestaurant
        [ForeignKey("RestaurantId")]
        public virtual TableRestaurant TableRestaurant { get; set; }
    }
}

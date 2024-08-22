using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GastroManagerBE.Models
{
    public class TableRestaurant : Auditory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int TableRestaurantId { get; set; }
        public bool Available { get; set; }
        public int Capacity { get; set; }
        public string Number { get; set; }
        public int RestaurantId { get; set; }

        // Relación con Restaurant
        [ForeignKey("RestaurantId")]
        public virtual Restaurant Restaurant { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GastroManagerBE.Models
{
    public class Product : Auditory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public bool Available { get; set; }
        public int CategoryId { get; set; }

        // Relación con Category
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}

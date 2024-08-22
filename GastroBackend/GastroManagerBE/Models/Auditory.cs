using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GastroManagerBE.Models
{
    public class Auditory
    {
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Medicament
    {
        public Medicament()
        {
            PrescriptionMedicaments = new HashSet<PrescriptionMedicament>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMedicament { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [MaxLength(100)]
        public string Type { get; set; }

        public virtual ICollection<PrescriptionMedicament> PrescriptionMedicaments { get; set; }
    }
}

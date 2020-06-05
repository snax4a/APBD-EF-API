using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class PrescriptionMedicament
    {
        public PrescriptionMedicament()
        {
          
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPrescriptionMedicament { get; set; }
        [ForeignKey("Medicament")]
        public int IdMedicament { get; set; }
        [ForeignKey("Prescription")]
        public int IdPrescription { get; set; }
        public virtual Medicament Medicament { get; set; }
        public virtual Prescription Prescription { get; set; }
    }
}

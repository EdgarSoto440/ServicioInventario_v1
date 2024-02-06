using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioInventario_V1.Modelos
{
    public class Bodega
    {
        [Key]
        public int BodegaID { get; set; }

        [Required(ErrorMessage ="Nombre es requerido")]
        [MaxLength(60,ErrorMessage ="Nombre debe tener maximo 60 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Descripción es requerida")]
        [MaxLength(100, ErrorMessage = "Nombre debe tener maximo 100 caracteres")]
        public string Descripcion { get; set; }

        [Required]
        public bool Estado { get; set; }



    }
}

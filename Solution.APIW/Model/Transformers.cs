using System;
using System.Collections.Generic;

namespace Solution.APIW.Model
{
    public partial class Transformers
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string SobreNombre { get; set; }
        public bool? Fallecio { get; set; }
        public string Raza { get; set; }
        public string Sociedad { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int? Edad { get; set; }
        public string Especialidad { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Solution.APIW.Model
{
    public partial class DragonBall
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string SobreNombre { get; set; }
        public string Raza { get; set; }
        public DateTime? Nacimiento { get; set; }
        public bool? Fallecio { get; set; }
        public int? Poder { get; set; }
        public string Universo { get; set; }
        public int? Edad { get; set; }
    }
}

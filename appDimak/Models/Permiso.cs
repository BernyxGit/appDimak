using System;
using System.Collections.Generic;

namespace appDimak.Models
{
    public partial class Permiso
    {
        public Permiso()
        {
            Emails = new HashSet<Employee>();
        }

        public int Idpermiso { get; set; }
        public string? Descripcion { get; set; }
        public bool? Activo { get; set; }

        public virtual ICollection<Employee> Emails { get; set; }
    }
}

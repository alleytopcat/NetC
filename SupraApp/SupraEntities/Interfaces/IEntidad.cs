using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupraEntities.Interfaces
{
    public interface IEntidad
    {
        Guid Id { get; set; }
        string Codigo { get; set; }
        string Nombre { get; set; }
        bool Activo { get; set; }
        string Usuario { get; set; }
        DateTime UltimoCambio { get; set; }
    }
}

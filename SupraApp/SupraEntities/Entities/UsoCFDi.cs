using SupraEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SupraEntities.Entities
{
    [DataContract(Name = "UsoCFDi")]

    public class UsoCFDi : IEntidad
    {
        [DataMember(Name = "id")]
        public Guid Id { get; set; }
        [DataMember(Name = "codigo")]
        public string Codigo { get; set; }
        [DataMember(Name = "nombre")]
        public string Nombre { get; set; }
        [DataMember(Name = "fiscia")]
        public bool Fisica { get; set; }
        [DataMember(Name = "moral")]
        public bool Moral { get; set; }
        [DataMember(Name = "vigenciaIni")]
        public DateTime VigenciaIni { get; set; }
        [DataMember(Name = "vigenciaFin")]
        public DateTime VigenciaFin { get; set; }
        [DataMember(Name = "activo")]
        public bool Activo { get; set; }
        [DataMember(Name = "usuario")]
        public string Usuario { get; set; }
        [DataMember(Name = "ultimoCambio")]
        public DateTime UltimoCambio { get; set; }
    }
}

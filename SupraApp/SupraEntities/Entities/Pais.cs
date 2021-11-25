using SupraEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SupraEntities.Entities
{
    [DataContract(Name = "Pais")]
    public class Pais : IEntidad
    {
        [DataMember(Name = "id")]
        public Guid Id { get; set; }
        [DataMember(Name = "codigo")]
        public string Codigo { get; set; }
        [DataMember(Name = "nombre")]
        public string Nombre { get; set; }
        [DataMember(Name = "nombreOficial")]
        public string NombreOficial { get; set; }
        [DataMember(Name = "codigoAlpha2")]
        public string CodigoAlpha2 { get; set; }
        [DataMember(Name = "codigoISONum")]
        public string CodigoISONum { get; set; }
        [DataMember(Name = "dominio")]
        public string Dominio { get; set; }
        [DataMember(Name = "prefijoTelefonico")]
        public string PrefijoTelefonico { get; set; }
        [DataMember(Name = "entidadesFederativas")]
        public List<EntidadFederativa> EntidadesFederativas { get; set; }
        [DataMember(Name = "activo")]
        public bool Activo { get; set; }
        [DataMember(Name = "usuario")]
        public string Usuario { get; set; }
        [DataMember(Name = "ultimoCambio")]
        public DateTime UltimoCambio { get; set; }
    }
}

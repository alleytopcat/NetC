using SupraEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SupraEntities.Entities
{
    [DataContract(Name = "Vista")]
    public class Vista : IEntidad
    {
        [DataMember(Name = "id")]
        public Guid Id { get; set; }
        [DataMember(Name = "codigo")]
        public string Codigo { get; set; }
        [DataMember(Name = "nombre")]
        public string Nombre { get; set; }
        [DataMember(Name = "colection")]
        public string Colection { get; set; }
        [DataMember(Name = "claseOrigen")]
        public string ClaseOrigen { get; set; }
        [DataMember(Name = "consulta")]
        public string Consulta { get; set; }
        [DataMember(Name = "appFormId")]
        public Guid AppFormId { get; set; }
        [DataMember(Name = "vistaItems")]
        public List<VistaItem> VistaItems { get; set; }
        [DataMember(Name = "vistaJoins")]
        public List<VistaJoin> VistaJoins { get; set; }
        [DataMember(Name = "activo")]
        public bool Activo { get; set; }
        [DataMember(Name = "usuario")]
        public string Usuario { get; set; }
        [DataMember(Name = "ultimoCambio")]
        public DateTime UltimoCambio { get; set; }
    }
}

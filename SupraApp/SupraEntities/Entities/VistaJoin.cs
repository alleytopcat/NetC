using SupraEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SupraEntities.Entities
{
    [DataContract(Name = "VistaJoin")]
    public class VistaJoin : IEntidad
    {
        [DataMember(Name = "id")]
        public Guid Id { get; set; }
        [DataMember(Name = "codigo")]
        public string Codigo { get; set; }
        [DataMember(Name = "nombre")]
        public string Nombre { get; set; }
        [DataMember(Name = "orden")]
        public int Orden { get; set; }
        [DataMember(Name = "vistaId")]
        public Guid VistaId { get; set; }
        [DataMember(Name = "vista")]
        public Vista Vista { get; set; }
        [DataMember(Name = "claseDestino")]
        public string ClaseDestino { get; set; }
        [DataMember(Name = "claseOrigen")]
        public string ClaseOrigen { get; set; }
        [DataMember(Name = "atributoOrigen")]
        public string AtributoOrigen { get; set; }
        [DataMember(Name = "atributoDestino")]
        public string AtributoDestino { get; set; }
        [DataMember(Name = "isInner")]
        public bool IsInner { get; set; }
        [DataMember(Name = "activo")]
        public bool Activo { get; set; }
        [DataMember(Name = "usuario")]
        public string Usuario { get; set; }
        [DataMember(Name = "ultimoCambio")]
        public DateTime UltimoCambio { get; set; }
    }
}

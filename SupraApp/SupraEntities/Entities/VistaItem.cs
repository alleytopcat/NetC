using SupraEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SupraEntities.Entities
{
    [DataContract(Name = "VistaItem")]
    public class VistaItem : IEntidad
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
        [DataMember(Name = "claseOrigen")]
        public string ClaseOrigen { get; set; }
        [DataMember(Name = "atributo")]
        public string Atributo { get; set; }
        [DataMember(Name = "caption")]
        public string Caption { get; set; }
        [DataMember(Name = "visible")]
        public bool Visible { get; set; }
        [DataMember(Name = "ordenable")]
        public bool Ordenable { get; set; }
        [DataMember(Name = "mascara")]
        public string Mascara { get; set; }
        [DataMember(Name = "activo")]
        public bool Activo { get; set; }
        [DataMember(Name = "usuario")]
        public string Usuario { get; set; }
        [DataMember(Name = "ultimoCambio")]
        public DateTime UltimoCambio { get; set; }
    }
}

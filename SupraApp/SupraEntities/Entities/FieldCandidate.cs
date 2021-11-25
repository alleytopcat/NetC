using SupraEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SupraEntities.Entities
{
    [DataContract(Name = "FieldCandidate")]
    public class FieldCandidate : IEntidad
    {
        [DataMember(Name = "id")]
        public Guid Id { get; set; }
        [DataMember(Name = "codigo")]
        public string Codigo { get; set; }
        [DataMember(Name = "nombre")]
        public string Nombre { get; set; }
        [DataMember(Name = "formFieldHeaderId")]
        public Guid FormFieldHeaderId { get; set; }
        [DataMember(Name = "formFieldHeader")]
        public FormFieldHeader FormFieldHeader { get; set; }
        [DataMember(Name = "claseOrigen")]
        public string ClaseOrigen { get; set; }
        [DataMember(Name = "vistaOrigenId")]
        public Guid? VistaOrigenId { get; set; }
        [DataMember(Name = "filtro")]
        public string Filtro { get; set; }
        [DataMember(Name = "atributoDescriptivo")]
        public string AtributoDescriptivo { get; set; }
        [DataMember(Name = "permiteCrear")]
        public bool PermiteCrear { get; set; }
        [DataMember(Name = "activo")]
        public bool Activo { get; set; }
        [DataMember(Name = "usuario")]
        public string Usuario { get; set; }
        [DataMember(Name = "ultimoCambio")]
        public DateTime UltimoCambio { get; set; }
    }
}

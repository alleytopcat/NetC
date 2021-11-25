using SupraEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SupraEntities.Entities
{
    [DataContract(Name = "FormFieldHeader")]
    public class FormFieldHeader : IEntidad
    {
        [DataMember(Name = "id")]
        public Guid Id { get; set; }
        [DataMember(Name = "codigo")]
        public string Codigo { get; set; }
        [DataMember(Name = "nombre")]
        public string Nombre { get; set; }
        [DataMember(Name = "formHeaderId")]
        public Guid FormHeaderId { get; set; }
        [DataMember(Name = "formHeader")]
        public FormHeader FormHeader { get; set; }
        [DataMember(Name = "atributo")]
        public string Atributo { get; set; }
        [DataMember(Name = "tipo")]
        public string Tipo { get; set; }
        [DataMember(Name = "orden")]
        public int Orden { get; set; }
        [DataMember(Name = "caption")]
        public string Caption { get; set; }
        [DataMember(Name = "readOnly")]
        public bool ReadOnly { get; set; }
        [DataMember(Name = "visible")]
        public bool Visible { get; set; }
        [DataMember(Name = "control")]
        public string Control { get; set; }
        [DataMember(Name = "fieldCandidates")]
        public List<FieldCandidate> FieldCandidates { get; set; }
        [DataMember(Name = "minValue")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal MinValue { get; set; }
        [DataMember(Name = "masValue")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal MaxValue { get; set; }
        [DataMember(Name = "mask")]
        public string Mask { get; set; }
        [DataMember(Name = "activo")]
        public bool Activo { get; set; }
        [DataMember(Name = "usuario")]
        public string Usuario { get; set; }
        [DataMember(Name = "ultimoCambio")]
        public DateTime UltimoCambio { get; set; }
    }
}

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
    [DataContract(Name = "Compania")]
    public class Compania : IEntidad
    {
        [DataMember(Name = "id")]
        public Guid Id { get; set; }
        [DataMember(Name = "codigo")]
        public string Codigo { get; set; }
        [DataMember(Name = "nombre")]
        public string Nombre { get; set; }
        [DataMember(Name = "personaId")]
        public Guid PersonaId { get; set; }
        [DataMember(Name = "persona")]
        public Persona Persona { get; set; }
        [DataMember(Name = "monedaId")]
        public Guid MonedaId { get; set; }
        [DataMember(Name = "Cmoneda")]
        public Moneda Moneda { get; set; }
        [DataMember(Name = "activo")]
        public bool Activo { get; set; }
        [DataMember(Name = "usuario")]
        public string Usuario { get; set; }
        [DataMember(Name = "ultimoCambio")]
        public DateTime UltimoCambio { get; set; }
    }
}

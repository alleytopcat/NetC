using SupraEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SupraEntities.Entities
{
    [DataContract(Name = "Telefono")]

    public class Telefono : IEntidad
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
        [DataMember(Name = "tipoTelefonoId")]
        public Guid TipoTelefonoId { get; set; }
        [DataMember(Name = "tipoTelefono")]
        public TipoTelefono TipoTelefono { get; set; }
        [DataMember(Name = "codigoPais")]
        public string CodigoPais { get; set; }
        [DataMember(Name = "codigoArea")]
        public string CodigoArea { get; set; }
        [DataMember(Name = "numero")]
        public string Numero { get; set; }
        [DataMember(Name = "extension")]
        public string Extension { get; set; }
        [DataMember(Name = "activo")]
        public bool Activo { get; set; }
        [DataMember(Name = "usuario")]
        public string Usuario { get; set; }
        [DataMember(Name = "ultimoCambio")]
        public DateTime UltimoCambio { get; set; }
    }
}

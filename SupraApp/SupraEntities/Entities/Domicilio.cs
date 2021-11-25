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
    [DataContract(Name = "Domicilio")]
    public class Domicilio : IEntidad
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
        [DataMember(Name = "tipoDomicilioId")]
        public Guid TipoDomicilioId { get; set; }
        [DataMember(Name = "tipoDomicilio")]
        public TipoDomicilio TipoDomicilio { get; set; }
        [DataMember(Name = "paisId")]
        public Guid PaisId { get; set; }
        [DataMember(Name = "pais")]
        public Pais Pais { get; set; }
        [DataMember(Name = "entidadFederativaId")]
        public Guid EntidadFederativaId { get; set; }
        [DataMember(Name = "entidadFederativa")]
        public EntidadFederativa EntidadFederativa { get; set; }
        [DataMember(Name = "calle")]
        public string Calle { get; set; }
        [DataMember(Name = "numeroExterior")]
        public string NumeroExterior { get; set; }
        [DataMember(Name = "numeroInterior")]
        public string NumeroInterior { get; set; }
        [DataMember(Name = "municipio")]
        public string Municipio { get; set; }
        [DataMember(Name = "ciudad")]
        public string Ciudad { get; set; }
        [DataMember(Name = "colonia")]
        public string Colonia { get; set; }
        [DataMember(Name = "codigoPostal")]
        public string CodigoPostal { get; set; }
        [DataMember(Name = "referencia")]
        public string Referencia { get; set; }
        [DataMember(Name = "activo")]
        public bool Activo { get; set; }
        [DataMember(Name = "usuario")]
        public string Usuario { get; set; }
        [DataMember(Name = "ultimoCambio")]
        public DateTime UltimoCambio { get; set; }

    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using SupraEntities.Interfaces;

namespace SupraEntities.Entities
{
    [DataContract(Name = "EntidadFederativa")]
    public class EntidadFederativa : IEntidad
    {
        [DataMember(Name = "id")]
        public Guid Id { get; set; }
        [DataMember(Name = "codigo")]
        public string Codigo { get; set; }
        [DataMember(Name = "nombre")]
        public string Nombre { get; set; }
        [DataMember(Name = "nombreOficial")]
        public string NombreOficial { get; set; }
        [DataMember(Name = "paisId")]
        public Guid PaisId { get; set; }
        [DataMember(Name = "pais")]
        public Pais Pais { get; set; }
        [DataMember(Name = "activo")]
        public bool Activo { get; set; }
        [DataMember(Name = "usuario")]
        public string Usuario { get; set; }
        [DataMember(Name = "ultimoCambio")]
        public DateTime UltimoCambio { get; set; }
    }
}

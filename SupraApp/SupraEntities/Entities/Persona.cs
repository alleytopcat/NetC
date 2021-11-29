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
    [DataContract(Name = "Persona")]
    public abstract class Persona : IEntidad
    {
        [DataMember(Name = "id")]
        public Guid Id { get; set; }
        [DataMember(Name = "codigo")]
        public string Codigo { get; set; }
        [DataMember(Name = "nombre")]
        public string Nombre { get; set; }
        [DataMember(Name = "RFC")]
        public string RFC { get; set; }
        [DataMember(Name = "domicilios")]
        public List<Domicilio> Domicilios { get; set; }
        [DataMember(Name = "telefonos")]
        public List<Telefono> Telefonos { get; set; }
        [DataMember(Name = "direccionElectronicas")]
        public List<DireccionElectronica> DireccionesElectronicas { get; set; }
        [DataMember(Name = "discriminator")]
        public string Discriminator { get; set; }
        [DataMember(Name = "activo")]
        public bool Activo { get; set; }
        [DataMember(Name = "usuario")]
        public string Usuario { get; set; }
        [DataMember(Name = "ultimoCambio")]
        public DateTime UltimoCambio { get; set; }
    }
}

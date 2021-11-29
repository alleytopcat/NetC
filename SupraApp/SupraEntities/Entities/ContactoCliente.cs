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
    [DataContract(Name = "ContactoCliente")]
    public class ContactoCliente : IEntidad
    {
        [DataMember(Name = "id")]
        public Guid Id { get; set; }
        [DataMember(Name = "codigo")]
        public string Codigo { get; set; }
        [DataMember(Name = "nombre")]
        public string Nombre { get; set; }
        [DataMember(Name = "clienteId")]
        public Guid ClienteId { get; set; }
        [DataMember(Name = "cliente")]
        public Cliente Cliente { get; set; }
        [DataMember(Name = "correoElectronico")]
        public string CorreoElectronico { get; set; }
        [DataMember(Name = "telefonoFijo")]
        public string TelefonoFijo { get; set; }
        [DataMember(Name = "telefonoMovil")]
        public string TelefonoMovil { get; set; }
        [DataMember(Name = "radio")]
        public string Radio { get; set; }
        [DataMember(Name = "activo")]
        public bool Activo { get; set; }
        [DataMember(Name = "usuario")]
        public string Usuario { get; set; }
        [DataMember(Name = "ultimoCambio")]
        public DateTime UltimoCambio { get; set; }
    }
}

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
    [DataContract(Name = "ImpuestoProveedor")]
    public class ImpuestoProveedor : IEntidad
    {
        [DataMember(Name = "id")]
        public Guid Id { get; set; }
        [DataMember(Name = "codigo")]
        public string Codigo { get; set; }
        [DataMember(Name = "nombre")]
        public string Nombre { get; set; }
        [DataMember(Name = "proveedorId")]
        public Guid ProveedorId { get; set; }
        [DataMember(Name = "proveedor")]
        public Proveedor Proveedor { get; set; }
        [DataMember(Name = "impuestoId")]
        public Guid ImpuestoId { get; set; }
        [DataMember(Name = "impuesto")]
        public Impuesto Impuesto { get; set; }
         [DataMember(Name = "activo")]
        public bool Activo { get; set; }
        [DataMember(Name = "usuario")]
        public string Usuario { get; set; }
        [DataMember(Name = "ultimoCambio")]
        public DateTime UltimoCambio { get; set; }
    }
}

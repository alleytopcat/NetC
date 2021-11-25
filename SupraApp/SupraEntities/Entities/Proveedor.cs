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
    [DataContract(Name = "Proveedor")]
    public class Proveedor : IEntidad
    {
        [DataMember(Name = "id")]
        public Guid Id { get; set; }
        [DataMember(Name = "codigo")]
        public string Codigo { get; set; }
        [DataMember(Name = "nombre")]
        public string Nombre { get; set; }
        [DataMember(Name = "nombreCorto")]
        public string NombreCorto { get; set; }
        [DataMember(Name = "companiaId")]
        public Guid CompaniaId { get; set; }
        [DataMember(Name = "compania")]
        public Compania Compania { get; set; }
        [DataMember(Name = "personaId")]
        public Guid PersonaId { get; set; }
        [DataMember(Name = "persona")]
        public Persona Persona { get; set; }
        [DataMember(Name = "diasCredito")]
        public int DiasCredito { get; set; }
        [Column(TypeName = "decimal(16,4)")]
        [DataMember(Name = "creditoMaximo")]
        public Decimal CreditoMaximo { get; set; }
        [DataMember(Name = "impuestosProveedor")]
        public List<ImpuestoProveedor> ImpuestosProveedor { get; set; }
        [DataMember(Name = "contactosProveedor")]
        public List<ContactoProveedor> ContactosProveedor { get; set; }
        [DataMember(Name = "cuentasBancariasProveedor")]
        public List<CuentaBancariaProveedor> CuentasBancariasProveedor { get; set; }
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

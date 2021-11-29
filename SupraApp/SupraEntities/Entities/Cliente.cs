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
    [DataContract(Name = "Cliente")]
    public abstract class Cliente : IEntidad
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
        [DataMember(Name = "vendedorId")]
        public Guid VendedorId { get; set; }
        [DataMember(Name = "vendedor")]
        public Vendedor Vendedor { get; set; }
        [DataMember(Name = "usoCFDiId")]
        public Guid UsoCFDiId { get; set; }
        [DataMember(Name = "usoCFDi")]
        public UsoCFDi UsoCFDi { get; set; }
        [DataMember(Name = "formaPagoId")]
        public Guid FormaPagoId { get; set; }
        [DataMember(Name = "formaPago")]
        public FormaPago FormaPago { get; set; }
        [DataMember(Name = "metodoPagoId")]
        public Guid MetodoPagoId { get; set; }
        [DataMember(Name = "metodoPago")]
        public MetodoPago MetodoPago { get; set; }
        [DataMember(Name = "diasCredito")]
        public int DiasCredito { get; set; }
        [Column(TypeName = "decimal(16,4)")]
        [DataMember(Name = "creditoMaximo")]
        public Decimal CreditoMaximo { get; set; }
        [DataMember(Name = "impuestosCliente")]
        public List<ImpuestoCliente> ImpuestosCliente { get; set; }
        [DataMember(Name = "contactosCliente")]
        public List<ContactoCliente> ContactosCliente { get; set; }
        [DataMember(Name = "cuentasBancariasCliente")]
        public List<CuentaBancariaCliente> CuentasBancariasCliente { get; set; }
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

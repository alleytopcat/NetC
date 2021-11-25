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
    [DataContract(Name = "CuentaBancariaProveedor")]
    public class CuentaBancariaProveedor : IEntidad
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
        [DataMember(Name = "bancoId")]
        public Guid BancoId { get; set; }
        [DataMember(Name = "banco")]
        public Banco Banco { get; set; }
        [DataMember(Name = "titularId")]
        public Guid TitularId { get; set; }
        [DataMember(Name = "titular")]
        public Persona Titular { get; set; }
        [DataMember(Name = "numero")]
        public string Numero { get; set; }
        [DataMember(Name = "clabe")]
        public string Clabe { get; set; }
        [DataMember(Name = "sucursal")]
        public string Sucursal { get; set; }
        [DataMember(Name = "plaza")]
        public string Plaza { get; set; }
        [DataMember(Name = "contrato")]
        public string Contrato { get; set; }
        [DataMember(Name = "numeroCliente")]
        public string NumeroCliente { get; set; }
        [DataMember(Name = "monedaId")]
        public Guid MonedaId { get; set; }
        [DataMember(Name = "moneda")]
        public Moneda Moneda { get; set; }
        [Column(TypeName = "decimal(16,4)")]
        [DataMember(Name = "saldoMonedaOriginal")]
        public decimal SaldoMonedaOriginal { get; set; }
        [Column(TypeName = "decimal(16,4)")]
        [DataMember(Name = "saldoMonedaNacional")]
        public decimal SaldoMonedaNacional { get; set; }
        [DataMember(Name = "activo")]
        public bool Activo { get; set; }
        [DataMember(Name = "usuario")]
        public string Usuario { get; set; }
        [DataMember(Name = "ultimoCambio")]
        public DateTime UltimoCambio { get; set; }
    }
}

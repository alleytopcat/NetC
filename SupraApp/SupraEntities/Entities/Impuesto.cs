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
    [DataContract(Name = "Impuesto")]
    public class Impuesto : IEntidad
    {
        [DataMember(Name = "id")]
        public Guid Id { get; set; }
        [DataMember(Name = "codigo")]
        public string Codigo { get; set; }
        [DataMember(Name = "nombre")]
        public string Nombre { get; set; }
        [DataMember(Name = "retenido")]
        public bool Retenido { get; set; }
        [DataMember(Name = "metodoCalculoId")]
        public Guid MetodoCalculoId { get; set; }
        [DataMember(Name = "metodoCalculo")]
        public MetodoCalculo MetodoCalculo { get; set; }
        [Column(TypeName = "decimal(16,4)")]
        [DataMember(Name = "coeficiente")]
        public Decimal Coeficiente { get; set; }
        [DataMember(Name = "activo")]
        public bool Activo { get; set; }
        [DataMember(Name = "usuario")]
        public string Usuario { get; set; }
        [DataMember(Name = "ultimoCambio")]
        public DateTime UltimoCambio { get; set; }
    }
}

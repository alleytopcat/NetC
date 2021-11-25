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
    [DataContract(Name = "PersonaMoral")]
    public class PersonaMoral : Persona
    {
        [DataMember(Name = "razonSocial")]
        public string RazonSocial { get; set; }
        [DataMember(Name = "fechaConstitucion")]
        public DateTime FechaConstitucion { get; set; }
        [DataMember(Name = "representanteLegalId")]
        public Guid? RepresentanteLegalId { get; set; }
        [DataMember(Name = "representanteLegal")]
        public PersonaFisica RepresentanteLegal { get; set; }
        [DataMember(Name = "paisId")]
        public Guid PaisId { get; set; }
        [DataMember(Name = "pais")]
        public Pais Pais { get; set; }
    }
}

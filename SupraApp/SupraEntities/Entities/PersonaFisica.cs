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
    [DataContract(Name = "PersonaFisica")]
    public class PersonaFisica : Persona
    {
        [DataMember(Name = "nombrePropio")]
        public string NombrePropio { get; set; }
        [DataMember(Name = "apellidoPaterno")]
        public string ApellidoPaterno { get; set; }
        [DataMember(Name = "apellidoMaterno")]
        public string ApellidoMaterno { get; set; }
        [DataMember(Name = "fechaNacimiento")]
        public DateTime FechaNacimiento { get; set; }
        [DataMember(Name = "CURP")]
        public string CURP { get; set; }
        [DataMember(Name = "sexoId")]
        public Guid SexoId { get; set; }
        [DataMember(Name = "sexo")]
        public Sexo Sexo { get; set; }
        [DataMember(Name = "estadoCivilId")]
        public Guid EstadoCivilId { get; set; }
        [DataMember(Name = "estadoCivil")]
        public EstadoCivil EstadoCivil { get; set; }
        [DataMember(Name = "paisNacimientoId")]
        public Guid PaisNacimientoId { get; set; }
        [DataMember(Name = "paisNacimiento")]
        public Pais PaisNacimiento { get; set; }
    }
}

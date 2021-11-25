using SupraEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupraEntities.Entities
{
    public class AppForm : IEntidad
    { 
        public Guid Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public List<FormHeader> FormHeaders { get; set; }
        public List<FormDetail> FormDetails { get; set; }
        public List<FormSummary> FormSummaries { get; set; }
        public List<AppFormUser> AppFormUsers { get; set; }
        public List<AppFormGroupUser> AppFormGroupUsers { get; set; }
        public string GroupUser { get; set; }
        public bool Activo { get; set; }
        public string Usuario { get; set; }
        public DateTime UltimoCambio { get; set; }
    }
}

using SupraEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupraEntities.Entities
{
    public class Menu : IEntidad
    {
        public Guid Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public Guid CompaniaId { get; set; }
        public Compania Compania { get; set; }
        public List<GroupMenu> GroupMenus { get; set; }
        public bool Activo { get; set; }
        public string Usuario { get; set; }
        public DateTime UltimoCambio { get; set; }
    }
}

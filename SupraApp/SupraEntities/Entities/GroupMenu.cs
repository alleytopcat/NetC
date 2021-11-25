using SupraEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupraEntities.Entities
{
    public class GroupMenu : IEntidad
    {
        public Guid Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public Guid MenuId { get; set; }
        public Menu Menu { get; set; }
        public List<MenuItem> MenuItems { get; set; }
        public List<GroupMenuUser> GroupMenuUsers { get; set; }
        public List<GroupMenuGroupUser> GroupMenuGroupUsers { get; set; }
        public string WebIcon { get; set; }
        public bool Activo { get; set; }
        public string Usuario { get; set; }
        public DateTime UltimoCambio { get; set; }

    }
}

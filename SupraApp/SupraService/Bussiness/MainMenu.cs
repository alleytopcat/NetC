using SupraEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupraService.Bussiness
{
    public class MainMenu
    {
        public Menu menu;
        public MainMenu(Guid companiaId, string token)
        {
            Menu oMenu = new Menu();
            oMenu.Id = Guid.NewGuid();
            oMenu.Codigo = "MainMenu";
            oMenu.Nombre = "Menu";
            oMenu.CompaniaId = companiaId;
            oMenu.Activo = true;
            oMenu.Usuario = "";
            oMenu.UltimoCambio = DateTime.Now;

            // Submenu Dashboard
            GroupMenu gmDashBoard = new GroupMenu();
            gmDashBoard.Id = Guid.NewGuid();
            gmDashBoard.Codigo = "gmDashBoard";
            gmDashBoard.Nombre = "DashBoard";
            gmDashBoard.Menu = oMenu;
            gmDashBoard.MenuId = oMenu.Id;
            gmDashBoard.Activo = true;
            gmDashBoard.Usuario = "";
            gmDashBoard.UltimoCambio = DateTime.Now;
            oMenu.GroupMenus.Add(gmDashBoard);

            // Item DashBoard
            MenuItem miDBPrincipal = new MenuItem();
            miDBPrincipal.Id = Guid.NewGuid();
            miDBPrincipal.Codigo = "miDBPrincipal";
            miDBPrincipal.Nombre = "DBPrincipal";
            miDBPrincipal.GroupMenu = gmDashBoard;
            miDBPrincipal.GroupMenuId = gmDashBoard.Id;
            miDBPrincipal.Activo = true;
            miDBPrincipal.Usuario = "";
            miDBPrincipal.UltimoCambio = DateTime.Now;
            gmDashBoard.MenuItems.Add(miDBPrincipal);

            // Submenu Solicitudes
            GroupMenu gmSolicitudes = new GroupMenu();
            gmSolicitudes.Id = Guid.NewGuid();
            gmSolicitudes.Codigo = "gmSolicitudes";
            gmSolicitudes.Nombre = "Solicitudes";
            gmSolicitudes.Menu = oMenu;
            gmSolicitudes.MenuId = oMenu.Id;
            gmSolicitudes.Activo = true;
            gmSolicitudes.Usuario = "";
            gmSolicitudes.UltimoCambio = DateTime.Now;
            oMenu.GroupMenus.Add(gmSolicitudes);

            // Items de Solicitud
            MenuItem miSolEntrada = new MenuItem();
            miSolEntrada.Id = Guid.NewGuid();
            miSolEntrada.Codigo = "miSolEntrada";
            miSolEntrada.Nombre = "Entrada";
            miSolEntrada.GroupMenu = gmSolicitudes;
            miSolEntrada.GroupMenuId = gmSolicitudes.Id;
            miSolEntrada.Activo = true;
            miSolEntrada.Usuario = "";
            miSolEntrada.UltimoCambio = DateTime.Now;
            gmSolicitudes.MenuItems.Add(miSolEntrada);

            MenuItem miSolSalida = new MenuItem();
            miSolSalida.Id = Guid.NewGuid();
            miSolSalida.Codigo = "miSolSalida";
            miSolSalida.Nombre = "Salida";
            miSolSalida.GroupMenu = gmSolicitudes;
            miSolSalida.GroupMenuId = gmSolicitudes.Id;
            miSolSalida.Activo = true;
            miSolSalida.Usuario = "";
            miSolSalida.UltimoCambio = DateTime.Now;
            gmSolicitudes.MenuItems.Add(miSolSalida);

            MenuItem miSolServicio = new MenuItem();
            miSolServicio.Id = Guid.NewGuid();
            miSolServicio.Codigo = "miSolServicio";
            miSolServicio.Nombre = "Servicio";
            miSolServicio.GroupMenu = gmSolicitudes;
            miSolServicio.GroupMenuId = gmSolicitudes.Id;
            miSolServicio.Activo = true;
            miSolServicio.Usuario = "";
            miSolServicio.UltimoCambio = DateTime.Now;
            gmSolicitudes.MenuItems.Add(miSolServicio);

            menu = oMenu;
        }
        public Menu GetMenu()
        {
            return menu;
        }
    }
}

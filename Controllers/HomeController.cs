using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tp_09.Models;

namespace tp_09.Controllers;
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CrearReserva()
        {
            ViewBag.ListaExhibiciones = BD.GetExhibiciones();
            return View("ComprarTickets");
        }

        public IActionResult GuardarReserva(Reserva reserva)
        {
            BD.InsertReserva(reserva);
            @ViewBag.Reserva = BD.GetReservaById(reserva.IdReserva);
                return View("Index");
        }

        public IActionResult SobreNosotros()
        {
            return View();
        }
        
    }

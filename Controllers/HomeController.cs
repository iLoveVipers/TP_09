﻿using System.Diagnostics;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using tp_09.Models;

namespace tp_09.Controllers;
    public class HomeController : Controller
    {
        private IWebHostEnvironment Environment;

        public HomeController(IWebHostEnvironment environment)
        {
            Environment= environment;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CrearReserva()
        {
            ViewBag.ListaExhibiciones = BD.GetExhibiciones();
            return View("ComprarTickets");
        }

        [HttpPost]
        public IActionResult GuardarReserva(Reservas reserva, IFormFile imgDNI)
        {
            if (imgDNI.Length >0)
            {
                string wwwRootLocal = this.Environment.ContentRootPath + @"\wwwroot\" + imgDNI.FileName;
                using(var stream = System.IO.File.Create(wwwRootLocal))
                {
                    imgDNI.CopyToAsync(stream);
                }
            }else{
                return RedirectToAction("CrearReserva");
            }
            reserva.DNI = imgDNI.FileName;
            BD.InsertReservas(reserva);
            ViewBag.Reserva = BD.GetReservaById(reserva.IdReserva);
            return View("Index");
        }

        public IActionResult SobreNosotros()
        {
            return View();
        }

        public IActionResult Exhibiciones()
        {
            ViewBag.ListaExhibiciones = BD.GetExhibiciones();
            return View();
        }
        
        public List<Reservas> Reserva(string Email)
        {
            return BD.GetReservaByEmail(Email);
        }
         
        public IActionResult BuscarReserva()
        {
            ViewBag.ListaResevas = BD.GetReservas();
            return View();
         }
    }

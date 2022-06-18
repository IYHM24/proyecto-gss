using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication_MVC.Data;
using WebApplication_MVC.Models;

namespace WebApplication_MVC.Controllers
{
    public class RegistroController : Controller
    {
       private readonly ApplicationDbContext _context;

        public RegistroController(ApplicationDbContext context)
        {
            this._context = context;
        }

        //HTTP GET Index
        public IActionResult Index()
        {
            return View(this.GettAllRegistry());
        }

        public List<Registro> GettAllRegistry()
        {
            var List = _context.Registro.FromSqlRaw<Registro>("RegistroProcess").ToList();
            return List;
        }

        [HttpPost]
        public IActionResult Index(DateTime fechaI, DateTime fechaF)
        {
            ViewBag.FechaI = fechaI;
            ViewBag.FechaF = fechaF;
            DateTime fecha_i = ViewBag.FechaI;
            DateTime fecha_f = ViewBag.FechaF;
            var List = _context.Registro.FromSqlRaw<Registro>("FiltrarFecha {0}, {1}", fecha_i, fecha_f).ToList();

            return View(List);
        }
    }
}

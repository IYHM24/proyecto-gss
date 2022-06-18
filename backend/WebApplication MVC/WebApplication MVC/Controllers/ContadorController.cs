using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApplication_MVC.Data;
using WebApplication_MVC.Models;

namespace WebApplication_MVC.Controllers
{
    public class ContadorController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ContadorController(ApplicationDbContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            return View(GettContador());
        }

        public Contador GettContador()
        {
            var Data = _context.Contador.FromSqlRaw<Contador>("contador").ToList();
            Contador contador = new Contador();
            contador.Id = 1;
            contador.ventas_por_dia = Data[0].ventas_por_dia;
            contador.ventas_por_mes = Data[0].ventas_por_mes;
            return contador;
        }
    }
}

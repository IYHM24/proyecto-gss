using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication_MVC.Data;
using WebApplication_MVC.Models;

namespace WebApplication_MVC.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ApplicationDbContext _context;


        public ClienteController(ApplicationDbContext context)
        {
            _context = context;
        }

        //HTTP GET Index
        public IActionResult Index()
        {
            IEnumerable<Cliente> listCliente = _context.Cliente;
            return View(listCliente);
        }

        //HTTP CREATE
        public IActionResult Create()
        {
            IEnumerable<Cliente> listCliente = _context.Cliente;
            return View();
        }

        //HTTP Post Create
        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid) 
            {
                _context.Cliente.Add(cliente);
                _context.SaveChanges();
            }
            return View();
        }

    }
}

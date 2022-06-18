using System;
using System.ComponentModel.DataAnnotations;
namespace WebApplication_MVC.Models
{
    public class Cliente
    {
        [Key]
        public int id_cliente { get; set; }
        public String cedula { get; set; }
        public String nombre { get; set; }
        public String telefono1 { get; set; }
        public String telefono2 { get; set; }
    }
}

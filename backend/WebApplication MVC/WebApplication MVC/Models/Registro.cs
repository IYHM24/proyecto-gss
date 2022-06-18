using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_MVC.Models
{

    public class Registro
    {
        [Key]
        public int id_alquiler { get; set; }
        public String cedula { get; set; }
        public String nombre { get; set; }
        public DateTime Fecha_Alquiler { get; set; }
        public int Tiempo_Alquilado { get; set; }
        public Decimal saldo { get; set; }
        public String placa { get; set; }
        public String marca { get; set; }
    }
}

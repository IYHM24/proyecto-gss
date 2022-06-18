using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_MVC.Models
{
    public class Pagos
    {
        [Key]
        public int id_pagos { get; set; }
        public DateTime fecha { get; set; }
        public Decimal valor { get; set; }
        public int id_alquiler { get; set; }
    }
}

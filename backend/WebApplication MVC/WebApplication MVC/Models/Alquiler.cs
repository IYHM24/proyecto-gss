using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_MVC.Models
{
    public class Alquiler
    {

        [Key]
        public int id_alquiler { get; set; }
        public DateTime fecha { get; set; }
        public int tiempo { get; set; }
        public Decimal valor_total { get; set; }
        public Decimal saldo { get; set; }
        public Decimal abono_inicial { get; set; }
        public Boolean devuelto { get; set; }
        public int id_carro { get; set; }
        public int id_cliente { get; set; }

    }
}

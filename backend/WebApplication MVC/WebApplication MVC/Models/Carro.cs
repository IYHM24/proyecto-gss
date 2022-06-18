using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_MVC.Models
{
    public class Carro
    {
        [Key]
        public int id_carro { get; set; }
        public String placa { get; set; }
        public String marca { get; set; }
        public int modelo { get; set; }
        public Decimal costo { get; set; }
        public Boolean disponible { get; set; }
    }
}

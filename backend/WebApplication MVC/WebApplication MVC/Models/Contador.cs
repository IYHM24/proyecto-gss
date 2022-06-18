using System.ComponentModel.DataAnnotations;

namespace WebApplication_MVC.Models
{
    public class Contador
    {
        [Key]
        public int Id { get; set; }
        public int ventas_por_dia { get; set; }
        public int ventas_por_mes { get; set; }
    }
}

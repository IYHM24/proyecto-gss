using System.ComponentModel.DataAnnotations;

namespace BackendRest.Model
{
    public class Pagos
    {
        [Key]
        public int id_pago { get; set; }
        public DateTime fecha { get; set; }
        public Decimal valor { get; set; }
        public int id_alquiler { get; set; }
    }
}

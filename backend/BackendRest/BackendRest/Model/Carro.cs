using System.ComponentModel.DataAnnotations;

namespace BackendRest.Model
{
    public class Carro
    {
        [Key]
        public int id_carro { get; set; }
        public string placa { get; set; }
        public string marca { get; set; }
        public int modelo { get; set; }
        public Decimal costo { get; set; }
        public Boolean disponible { get; set; }
    }
}

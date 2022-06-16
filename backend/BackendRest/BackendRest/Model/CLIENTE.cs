using System.ComponentModel.DataAnnotations;

namespace BackendRest.Model
{
    public class Cliente
    {
        [Key]
        public int  id_cliente { get; set; }
        public String cedula { get; set; }
        public String Nombre { get; set; }
        public String Telefono1 { get; set; }
        public String Telefono2 { get; set; }
    }
}

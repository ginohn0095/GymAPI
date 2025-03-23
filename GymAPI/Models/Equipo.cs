namespace GymAPI.Models
{
    public class Equipo
    {
        public int ID { get; set; }
        public string? Nombre { get; set; }
        public int MarcaID { get; set; }
        public int ProveedorID { get; set; }
        public string? Estado { get; set; }
        public DateTime FechaCompra { get; set; }
    }
}

namespace Concentrador_Scanntech_Entities.Dtos.Promocoes
{
    public class ResultDto
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public string tipo { get; set; }
        public DetallesDto detalles { get; set; }
        public AutorDto autor { get; set; }
        public string vigenciaDesde { get; set; }
        public string vigenciaHasta { get; set; }  
    }
}

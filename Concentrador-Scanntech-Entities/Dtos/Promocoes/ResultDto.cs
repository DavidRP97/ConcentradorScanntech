namespace Concentrador_Scanntech_Entities.Dtos.Promocoes
{
    public class ResultDto
    {
        public bool CargaPDV { get; set; }
        public int id { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public string tipo { get; set; }
        public DetallesDto detalles { get; set; }
        public AutorDto autor { get; set; }
        public DateTime vigenciaDesde { get; set; }
        public DateTime vigenciaHasta { get; set; }
        public DateTime DataEnvioPDV { get; set; }
    }
}

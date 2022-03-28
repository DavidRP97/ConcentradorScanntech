namespace Concentrador_Scanntech_Entities.Dtos.Promocoes
{
    public class DetallesDto
    {
        public virtual CondicionesDto condiciones { get; set; }
        public virtual BeneficiosDto beneficios { get; set; }
        public decimal? precio { get; set; }
        public decimal? descuento { get; set; }
        public int? paga { get; set; }
    }
}
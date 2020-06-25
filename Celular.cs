namespace SimulacionEconomica
{
    class Celular
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; }
        public float ConsumoElectrico { get; set; }
        public Persona Propietario { get; set; }
    }
}

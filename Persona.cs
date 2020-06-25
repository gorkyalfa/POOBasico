namespace SimulacionEconomica
{
    class Persona
    {
        // Propiedades - Estado
        public int Id { get; set; }
        public string Nombre { get; set; }

        Celular elCelular;
        public Celular MiCelular
        {
            get 
            {
                return elCelular;
            }

            set
            {
                elCelular = value;
                elCelular.Propietario = this;
            }
        }

        // Métodos - Comportamiento
        public string Saludar(string nombre)
        {
            return $"Hola {nombre} me llamo {Nombre}";
        }

        public string Productos() 
        {
            if (celular != null)
                return $"Tengo un celular {celular.Modelo}";
            else
                return "No tengo celular";
        }
    }
}
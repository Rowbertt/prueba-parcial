namespace prueba_parcial
{
    public class Animal
    {
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Alimentacion { get; set; }
        public int Vida { get; set; }

        public Animal()
        {
            Nombre = string.Empty;
            Especie = string.Empty;
            Alimentacion = string.Empty;
            Vida = 0;
        }

    }
}

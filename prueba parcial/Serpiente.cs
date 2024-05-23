namespace prueba_parcial
{
    public class Serpiente : Animal
    {
        public bool Venenosa { get; set; }
        public float LongitudMaxima { get; set; }

        public Serpiente() : base()
        {
            Venenosa = false;
            LongitudMaxima = 0.0f;
        }
    }
}

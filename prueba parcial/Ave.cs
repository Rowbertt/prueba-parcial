namespace prueba_parcial
{
    public class Ave : Animal
    {
        public bool Vuela { get; set; }
        public int Incubacion { get; set; }

        public Ave() : base()
        {
            Vuela = false;
            Incubacion = 0;
        }
    }
}

namespace Iheritance_interface
{
    public class Vehical
    {
        public float Speed { get; set; }
        public string Color { get; set; }

        public Vehical()
        {
            Speed = 10.92f;
            Color = "blue";

        }
        public Vehical (float speed , string color)
        {
            Speed = speed;
            Color = color;

        }
    }
}
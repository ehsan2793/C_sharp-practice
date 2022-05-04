namespace Iheritance_interface
{
    public class Furniture
    {
        public string Color { get; set; }
        public string Material { get; set; }

        public Furniture()
        {
            Color = "color from Furniture";
            Material = "material from Furniture";
        }

        public Furniture(string color , string material)
        {
            Color = color;
            Material = material;
        }
    }
}
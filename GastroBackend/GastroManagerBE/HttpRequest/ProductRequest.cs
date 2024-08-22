namespace GastroManagerBE.HttpRequest
{
    public class ProductRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public bool Available { get; set; }
        public int CategoryId { get; set; }
    }
}

namespace BlazorAppTest.Models
{
    public class Product
    {
        public int IdProduct { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<ProductProp> ProductProp { get; set; }    
    }
}

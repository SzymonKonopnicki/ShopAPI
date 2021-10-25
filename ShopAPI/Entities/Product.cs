namespace ShopAPI.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public bool Available { get; set; }
        public double PriceS { get; set; }

        public int OrderId {  get; set; }
        public Order Order { get; set; }


        //public int PriceM { get; set; }
        //public int PriceL { get; set; }
    }
}

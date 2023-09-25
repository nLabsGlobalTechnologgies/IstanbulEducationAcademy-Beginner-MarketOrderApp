namespace MarketOrderApp
{
    public class Basket
    {
        public Basket()
        {
            
        }

        public Basket(string name, int piece, decimal price, decimal total)
        {
            Name = name;
            Piece = piece;
            Price = price;
            Total = total;
        }

        public string Name { get; set; }
        public int Piece { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
    }
}

namespace CoinHarmony.Models
{
    public class CryptoCurrency
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public decimal Price { get; set; }
        // Əlavə atributlar əlavə edə bilərsiniz

        public CryptoCurrency(string name, string symbol, decimal price)
        {
            Name = name;
            Symbol = symbol;
            Price = price;
        }
    }
}

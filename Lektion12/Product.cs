using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion12
{
    internal class Product
    {
        //Properties
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        private int StockQuantity { get; set; }



        //Constructor

        public Product(string ProductName, decimal Price, int StockQuantity)
        {
            this.ProductName = ProductName;
            this.Price = Price;
            this.StockQuantity = StockQuantity;
        }

        //Methods

        public void DisplayProduct()
        {
            Console.WriteLine($"Article: {ProductName}, Price: {Price}");
        }
        private void UpdateStockQuantity(int quantity)
        {
            StockQuantity += quantity;
            Console.WriteLine($"Stock for {ProductName} has been updated, new stock: {StockQuantity}");
        }

        public void Restock(int quantity)
        {
            if (quantity <= 0)
            {
                Console.WriteLine($"ERROR: Cannot update stock to negative value: {quantity}.");
            }
            else
            {
                UpdateStockQuantity(quantity);
            }
        }

        public bool Purchase(int quantity)
        {
            if (StockQuantity >= quantity)
            {
                StockQuantity -= quantity;
                Console.WriteLine($"Purchase successful, {quantity} of {ProductName} has been added to your inventory");
                return true;
            }
            else
            {
                Console.WriteLine($"Sorry, we don't have enough {ProductName} in stock to complete this purchase.");
                return false;
            }
        }
    }
}

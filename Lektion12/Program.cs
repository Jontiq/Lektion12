namespace Lektion12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User user = new User("Jontiq", "jonathan@mail.se", "password123");
            //user.Login("Jontiq", "password123");
            //user.ChangePassword("password123", "123password");
            //user.Login("Jontiq", "123password");

            Product product = new Product("Milk", 15.95m, 25);
            product.DisplayProduct();
            product.Restock(50);
            product.Purchase(20);
            product.Purchase(31);
        }
    }
}

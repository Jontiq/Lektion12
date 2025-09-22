using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

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

            //Product product = new Product("Milk", 15.95m, 25);
            //product.DisplayProduct();
            //product.Restock(50);
            //product.Purchase(20);
            //product.Purchase(31);

            // Listan som håller talen
            List<int> lista = new List<int> { 1, 2, 3, 4, 5, 6, 7, };
            double average;
            int sum;
            //Anropar metod
            CalculateSumAndAverage(lista, out average, out sum);

            // Skriv ut resultatet
            Console.WriteLine($"Summan av talen är: {sum}");
            Console.WriteLine($"Medelvärdet av talen är: {average}");
        }
        public static void CalculateSumAndAverage(List <int> list, out double average, out int sum)
        {
            sum = 0;
            foreach(int num in list)
            {
                sum += num;
            }
            average = sum / list.Count();
        }
    }
}

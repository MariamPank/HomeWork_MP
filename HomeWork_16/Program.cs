namespace HomeWork_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductWeight product1 = new ProductWeight("product1", Unit.kg,10);
            ProductWeight product2 = new ProductWeight("product2", Unit.gr, 100);
            ProductWeight product3 = new ProductWeight("product3", Unit.kg, 45);
            ProductWeight product4 = new ProductWeight("product4", Unit.tn, 50);
            ProductWeight product5 = new ProductWeight("product5", Unit.gr, 240);
            ProductWeight product6 = new ProductWeight("product6", Unit.kg, 46);

            Console.WriteLine(product1);
            Console.WriteLine(product2);
            Console.WriteLine(product3);
            Console.WriteLine(product4);
            Console.WriteLine(product5);
            Console.WriteLine(product6);

            Console.WriteLine(product2.CompareTo(product5));

            Console.WriteLine(product1+product3);
            Console.WriteLine(product1 < product3);

        }
    }
}

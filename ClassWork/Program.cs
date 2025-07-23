namespace ClassWork
{
    internal class Program
    {
      //დაწერეთ მეთოდი სხელად FindAll რომელიც მიიღებს ლისტს სადაც უნდა მოხდეს ელემენტების მოძებნა, ასევე მიიღებს შესაბამის დელეგატს და დაგვიბრუნებს ნაპოვნი ელემენტების ლისტს

        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 3, 8, 15, 22, 5, 12, 30 };

            List<int> filteredList = FindAll(numbers, n => n > 10);

            Console.WriteLine("Numbers > 10:");
            foreach (var num in filteredList)
            {
                Console.WriteLine(num);
            }
        }

        static List<int> FindAll(List<int> list, Predicate<int> predicate)
        {
            List<int> result = new List<int>();

            foreach (var x in list)
            {
                if (predicate(x))
                {
                    result.Add(x);
                }
            }

            return result;
        }
    }
}
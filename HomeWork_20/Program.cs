namespace HomeWork_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new () { 20,11,40,53,10,10,50,40};


            Console.WriteLine("Task - 1");
            List<int> newOne = Classes.MyDistinct(list, (result, i) =>
            {
                if (!result.Contains(i))
                {
                    result.Add(i);
                }
            });

            foreach (int i in newOne) { 
            Console.WriteLine(i);
            }


            Console.WriteLine("Task - 2");
            List<int> rev = Classes.MyReverse(newOne);
            foreach (int i in rev)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Task - 3");

            List<int> newRev = Classes.MyReversed(newOne, x => x % 2 != 0);
            foreach (int i in newRev)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Task - 4");

            var any = Classes.MyAny(list, x => x == 45);

            Console.WriteLine(any);

            Console.WriteLine("Task - 5");

            var all = Classes.MyAll(list, x => x > 2);

            Console.WriteLine(all);

            Console.WriteLine("Task - 6");
            Console.WriteLine("option 1");

            int max1 = Classes.MyMax(list);
            Console.WriteLine(max1);

            Console.WriteLine("option 2");
            int max2 = Classes.MyMiniMax(list, (x, max) => x > max);
            Console.WriteLine(max2);

            Console.WriteLine("Task - 7");
            Console.WriteLine("option 1");

            int min1 = Classes.MyMin(list);
            Console.WriteLine(min1);

            Console.WriteLine("option 2");
            int min2 = Classes.MyMiniMax(list, (x, min) => x < min);
            Console.WriteLine(min2);

            Console.WriteLine("Task - 8");

            List<int> newL = Classes.MyTake(list, 2);

            foreach(int i  in newL)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Task - 9");

            List<int> skiped = Classes.MySkip(list, 4);
            foreach (int i in skiped)
            {
                Console.WriteLine(i);
            }
        }
    }
}

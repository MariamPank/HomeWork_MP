using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_20
{
    public class Classes
    {
        //🔹 1. MyDistinct(List<int> source)
        //აღწერა:
        //დაბრუნეთ ახალი სია იმ ელემენტებით, რომლებიც უნიკალურია.იგივე მნიშვნელობა სიაში არ უნდა განმეორდეს.

        //მოთხოვნები:

        //არ გამოიყენოთ HashSet.

        //შედეგები დააბრუნეთ იმ მიმდევრობით, როგორც წყაროშია.


        public static List<int> MyDistinct(List<int> source, Action<List<int>, int> filter)
        {
            List<int> result = new List<int>();
            foreach (int i in source)
            {
                filter(result, i);
            }
            return result;
        }


        //🔹 2. MyReverse(List<int> source)
        //        აღწერა:
        //დაბრუნეთ სია შებრუნებული მიმდევრობით.

        //მაგ: [1, 2, 3] → [3, 2, 1]

        public static List<int> MyReverse(List<int> source)
        {
            List<int> reversed = new List<int>();

            for (int i = source.Count - 1; i >= 0; i--)
            {
                reversed.Add(source[i]);
            }

            return reversed;
        }


        //        🔹 3. MyReversed(List<int> source, Func<int, bool> predicate)
        //აღწერა:
        //დაბრუნეთ ახალი სია, რომელიც შეიცავს მხოლოდ იმ ელემენტებს, რომლებიც აკმაყოფილებენ პირობას(predicate) და არის შებრუნებული მიმდევრობით.

        //მაგ: [1, 2, 3, 4] და x => x % 2 == 0 → [4, 2]


        public static List<int> MyReversed(List<int> source, Func<int, bool> predicate)
        {
            List<int> newRev = new List<int>();
            for (int i = source.Count - 1; i >= 0; i--)
            {
                if (predicate(source[i]))
                {
                    newRev.Add(source[i]);
                }
            }
            return newRev;
        }

        //        🔹 4. MyAny(List<int> source, Func<int, bool> predicate)
        //აღწერა:
        //დააბრუნეთ true, თუ არსებობს მინიმუმ ერთი ელემენტი, რომელიც აკმაყოფილებს მოცემულ პირობას.

        public static bool MyAny(List<int> source, Func<int, bool> predicate)
        {
            foreach (int i in source)
            {
                if (predicate(i))
                {
                    return true;
                }
            }
            return false;
        }


        //        🔹 5. MyAll(List<int> source, Func<int, bool> predicate)
        //აღწერა:
        //დააბრუნეთ true, თუ ყველა ელემენტი აკმაყოფილებს მოცემულ პირობას.

        public static bool MyAll(List<int> source, Func<int, bool> predicate)
        {
            foreach (int i in source)
            {
                if (!predicate(i))
                {
                    return false;
                }
            }
            return true;
        }

        //        🔹 6. MyMax(List<int> source)
        //აღწერა:
        //დააბრუნეთ სიაში არსებული მაქსიმალური მნიშვნელობა.

        //შენიშვნა:
        //თუ სია ცარიელია, უნდა ისროლოს გამონაკლისი(ArgumentException).

        public static int MyMax(List<int> source)
        {
            if (source == null || source.Count == 0)
            {
                throw new ArgumentException("The list is empty.");
            }
            int max = source[0];
            foreach (int i in source)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }

        public static int MyMiniMax(List<int> source, Func<int, int, bool> minmax)
        {
            if (source == null || source.Count == 0)
            {
                throw new ArgumentException("The list is empty.");
            }
            int mm = source[0];
            foreach (int i in source)
            {
                if (minmax(i, mm))
                {
                    mm = i;
                }
            }
            return mm;
        }

        //🔹 7. MyMin(List<int> source)
        //აღწერა:
        //დააბრუნეთ სიაში არსებული მინიმალური მნიშვნელობა.

        //შენიშვნა:
        //თუ სია ცარიელია, უნდა ისროლოს გამონაკლისი(ArgumentException).

        public static int MyMin(List<int> source)
        {
            if (source == null || source.Count == 0)
            {
                throw new ArgumentException("The list is empty.");
            }
            int min = source[0];
            foreach (int i in source)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }


        //        🔹 8. MyTake(List<int> source, int count)
        //აღწერა:
        //დააბრუნეთ სია, რომელიც შეიცავს მხოლოდ პირველ count რაოდენობის ელემენტს.

        //მაგ: MyTake([1, 2, 3, 4, 5], 3) → [1, 2, 3]

        public static List<int> MyTake(List<int> source, int count)
        {
            List<int> listC = new List<int>();

            int actCount = Math.Min(count, source.Count);

            for (int i= 0; i < actCount; i++)
            {
                listC.Add(source[i]);
            }
            return listC;
        }

        //        🔹 9. MySkip(List<int> source, int count)
        //აღწერა:
        //დაბრუნეთ სია, რომელიც შეიცავს ყველა იმ ელემენტს, რაც იწყება count ინდექსიდან.

        //მაგ: MySkip([1, 2, 3, 4, 5], 2) → [3, 4, 5]

        public static List<int> MySkip(List<int> source, int count)
        {
            List<int> skipL = new List<int>();

            int actCount = Math.Min(count, source.Count);
            for (int i = actCount; i < source.Count; i++)
            {
                skipL.Add(source[i]);
            }

            return skipL;
        }
    }
}

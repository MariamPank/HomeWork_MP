using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_21
{
    public static class Algorithms
    {
        public static int Custom_FirstIndex(IEnumerable<int> intList, Func<int, bool> predicate)
        {
            foreach (int item in intList)
            {
                if (predicate(item))
                {
                    return item;
                }
            }

            return -1;
        }


        public static int Custom_LastIndex(IEnumerable<int> intList, Predicate<int> predicate)
        {
            int result = 0;
            foreach (int item in intList)
            {
                if (predicate(item))
                {
                    result = item;
                }
            }
            return result;
        }


        // CHECKKKK!!!!
        public static List<int> Custom_OrderBy(IEnumerable<int> intList, Func<int, int, bool> compareFunction)
        {
            List<int> list = intList.ToList();

            int i = 0;
            foreach (var outer in list)
            {
                int j = i + 1;
                foreach (var inner in list.Skip(i + 1))
                {
                    if (compareFunction(inner, list[i]))
                    {
                        int temp = list[j];
                        list[j] = list[i];
                        list[i] = temp;
                    }
                    j++;
                }
                i++;
            }

            return list;
        }

        public static int Custom_Sum(IEnumerable<int> intList)
        {
            int sum = 0;
            foreach (int i in intList)
            {
                sum += i;
            }
            return sum;
        }

        public static int Custom_Sum(IEnumerable<int> intList, Predicate<int> predicate)
        {
            int sum = 0;
            foreach (int i in intList)
            {
                if (predicate(i))
                {
                    sum += i;
                }
            }
            return sum;
        }
        public static int Custom_Count(IEnumerable<int> intList)
        {
            int count = 0;

            foreach (int i in intList)
            {
                count++;
            }

            return count;
        }

        public static int Custom_Count(IEnumerable<int> intList, Predicate<int> predicate)
        {
            int count = 0;

            foreach (int i in intList)
            {
                if (predicate(i))
                {
                    count++;
                }
            }
            return count;
        }

        public static List<int> Custom_Distinct(IEnumerable<int> intList)
        {
            List<int> result = new();
            foreach (int i in intList)
            {
                if (!result.Contains(i))
                    result.Add(i);
            }
            return result;
        }

        public static List<int> Custom_Reverse(IEnumerable<int> intList)
        {
            List<int> result = new();

            foreach (var item in intList)
            {
                result.Insert(0, item);
            }

            return result;
        }

        public static List<int> Custom_Reverse(IEnumerable<int> intList, Func<int, bool> predicate)
        {
            List<int> result = new();

            foreach (var item in intList)
            {
                if (predicate(item))
                {
                    result.Insert(0, item);
                }
            }

            return result;
        }

        public static int Custom_Max(IEnumerable<int> intList)
        {
            bool first = true;
            int max = 0;

            foreach (int item in intList)
            {
                if (first)
                {
                    max = item;
                    first = false;
                }
                else if (item > max)
                {
                    max = item;
                }
            }
            if (first)
            {
                throw new InvalidOperationException("Sequence contains no elements.");
            }
            return max;
        }



        public static int Custom_Min(IEnumerable<int> intList)
        {
            bool first = true;
            int min = 0;

            foreach (int item in intList)
            {
                if (first)
                {
                    min = item;
                    first = false;
                }
                else if (item < min)
                {
                    min = item;
                }
            }

            if (first)
            {
                throw new InvalidOperationException("Sequence contains no elements.");
            }
            return min;
        }

        public static List<int> Custom_Take(IEnumerable<int> intList, int count)
        {
            List<int> result = new();
            int taken = 0;

            foreach (int item in intList)
            {
                if (taken >= count)
                    break;

                result.Add(item);
                taken++;
            }

            return result;
        }

        public static List<int> Custom_Skip(IEnumerable<int> intList, int count)
        {
            List<int> result = new();
            int skipped = 0;

            foreach (int item in intList)
            {
                if (skipped < count)
                {
                    skipped++;
                    continue;
                }

                result.Add(item);
            }

            return result;
        }


    }
}

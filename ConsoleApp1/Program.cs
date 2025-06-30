using Microsoft.VisualBasic;
using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Homework - Lesson 2
            //Task #1

            //Console.Write("Your Favourite Movie: ");
            //string movieName = Console.ReadLine();

            //Console.Write("Director's First and Last Name: ");
            //string director = Console.ReadLine();
            //Console.Write("Release Year: ");
            //Int32 releaseYear = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Brief Description: ");
            //string description = Console.ReadLine();
            //Console.Write("Budget: USD ");
            //Int32 budget = Convert.ToInt32(Console.ReadLine());
            //Console.Write("IMDB Rating: ");
            //double rating = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Golden Globe [Y/N]: ");
            //char goldenGlobe = char.Parse(Console.ReadLine());

            //Console.Write("Oscar Winner [True/False]: ");
            //bool oscar = bool.Parse(Console.ReadLine());


            //if ( goldenGlobe == 'Y' && oscar)
            //{
            //    Console.WriteLine($"Hi, my favourite movie is {movieName}, directed by {director}. The movie was released in {releaseYear}. Brief Description: {description}. Budget - {budget}. IMDB: {rating}. This movie won the Golden Globe and the Oscar");
            //}
            //else if(oscar)
            //{
            //    Console.WriteLine($"Hi, my favourite movie is {movieName}, directed by {director}. The movie was released in {releaseYear}. Brief Description: {description}. Budget - {budget}. IMDB: {rating}. This movie won the Oscar");
            //}
            //else if (goldenGlobe == 'Y')
            //{
            //    Console.WriteLine($"Hi, my favourite movie is {movieName}, directed by {director}. The movie was released in {releaseYear}. Brief Description: {description}. Budget - {budget}. IMDB: {rating}. This movie won the Golden Globe");
            //}
            //else
            //{
            //    Console.WriteLine($"Hi, my favourite movie is {movieName}, directed by {director}. The movie was released in {releaseYear}. Brief Description: {description}. Budget - {budget}. IMDB: {rating}");
            //}


            //Task #2
            //Console.Write("First Name: ");
            //string firstName = Console.ReadLine();
            //Console.Write("Last Name: ");
            //string lastName = Console.ReadLine();
            //Console.Write("Personal ID: ");
            //string personalId = Console.ReadLine();
            //Console.Write("Age: ");
            //byte age = Convert.ToByte(Console.ReadLine());
            //Console.Write("Height: ");
            //Int32 height = Int32.Parse(Console.ReadLine());
            //Console.Write("Weight: ");
            //Int32 weight = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Married [True/False]: ");
            //Boolean married = Boolean.Parse(Console.ReadLine());
            //Console.Write("Pets [True/False]: ");
            //Boolean pets = Boolean.Parse(Console.ReadLine());

            //if(married && pets)
            //{
            //    Console.WriteLine($"Hi, my name is {firstName} {lastName}, my personal ID is {personalId}, I am {age} years old, my height is {height} cm, my weight is {weight} kg. I am married and I have pets.");
            //}
            //else if (married)
            //{
            //    Console.WriteLine($"Hi, my name is {firstName} {lastName}, my personal ID is {personalId}, I am {age} years old, my height is {height} cm, my weight is {weight} kg. I am married.");
            //}
            //else if (pets)
            //{
            //    Console.WriteLine($"Hi, my name is {firstName} {lastName}, my personal ID is {personalId}, I am {age} years old, my height is {height} cm, my weight is {weight} kg. I have pets.");
            //}
            //else
            //{
            //    Console.WriteLine($"Hi, my name is {firstName} {lastName}, my personal ID is {personalId}, I am {age} years old, my height is {height} cm, my weight is {weight} kg.");

            //}

            #endregion

            #region Homework - Lesson 3

            ////1. ლექციის განმავლობაში ნაჩვენები ოპერატორების გამოყენებით ჩაატარეთ ყველა მათემატიკური ოპერაცია შეკრიბეთ გამოაკელით გაამრავლეთ და გაყავით ორი რიცხვი.პროგრამის მუშაობის რეალიზაცია მოახდინეთ კონსოლში.
            //int a = 16;
            //int b = 8;
            //Console.WriteLine("Mathematical Operations: ");
            //Console.WriteLine($"Add: {a} + {b} = {a + b}");
            //Console.WriteLine($"Substract: {a} - {b} = {a - b}");
            //Console.WriteLine($"Multiply: {a} * {b} = {a * b}");
            //Console.WriteLine($"Divide: {a} / {b} = {(double)a / b}");


            ////2. კონსოლიდან მომხმარებელს შემოაყვანინეთ ორი რიცხვი, ეს რიცხვები ერთმანეთს მიუმატეთ გამოაკელით გაამრავლეთ და გაყავით.პროგრამის მუშაობის რეალიზაცია მოახდინეთ კონსოლში.
            //Console.Write("Please enter the first number: ");
            //Int32 firstNumber = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Please enter the second number: ");
            //Int32 secondNumber = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Mathematical Operations: ");
            //Console.WriteLine($"Add: {firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            //Console.WriteLine($"Substract: {firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            //Console.WriteLine($"Multiply: {firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            //if (secondNumber != 0)
            //    Console.WriteLine($"{firstNumber} / {secondNumber} = {(double)firstNumber / secondNumber}");
            //else
            //    Console.WriteLine("Cannot divide by zero");


            ////3. მოცემულია int ტიპის ცვლადი რომელიც ინახავს რაღაც რიცხვს.ლექციაში ნაჩვენები ოპერატორების გამოყენებით გაზარდეთ ამ ცვლდის მნიშვნელობა 3 - ჯერ.
            //int value1 = 6;
            //Console.WriteLine($"Original value: {value1}");
            //value1 *= 3;
            //Console.WriteLine($"multiplied by 3: {value1}");


            ////4. მოცემულია int ტიპის ცვლადი რომელიც ინახავს რაღაც რიცხვს.ლექციაში ნაჩვენები ოპერატორების გამოყენებით გაზარდეთ ამ ცვლდის მნიშვნელობა 2 - ით და შეამცირეთ 4 - ით.
            //int value2 = 6;
            //value2 += 2;
            //value2 -= 4;
            //Console.WriteLine($"add 2 and substract 4: {value2}");


            ////5. დაწერეთ პროგრამა სადაც მომხმარებელს შემოჰყავს ორი რიცხვი.პროგრამა ერთმანეთს ადარებს ამ ორ რიცხვს და გამოაქვს შესაბამისი შეტყობინება.(ეს რიცხვები ტოლია ან პირველი მეტია მეორეზე ან მეორე მტია პირველზე)
            //Console.Write("Please enter the first number: ");
            //Int32 n1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please enter the second number: ");
            //Int32 n2 = Convert.ToInt32(Console.ReadLine());

            //if (n1 == n2)
            //    Console.WriteLine("These numbers are equal.");
            //else if (n1 > n2)
            //    Console.WriteLine("The first number is greater than the second.");
            //else
            //    Console.WriteLine("The second number is greater than the first.");


            ////6. დაწერეთ პროგრამა სადაც მომხმარებელს შემოჰყავს რიცხვი, თუ ეს რიცხვი მეტია 5 - ზე  და ნაკლებია 10 - ზე,კონსოლში დაიბეჭდება შესაბამსი შეტყობინება(რიცხვი მეტია 5 - ზე და ნაკლებია 10 - ზე),წინააღმდეგ შემთხვევაში დაიბეჭდება(უცნობი რიცხვი)
            //Console.Write("Please enter the number: ");
            //Int32 num1 = Convert.ToInt32(Console.ReadLine());

            //if (num1 > 5 && num1 < 10)
            //{
            //    Console.WriteLine("The number is greater than 5 and less than 10");
            //}
            //else
            //{
            //    Console.WriteLine("Unknown Number");
            //}


            ////7. დაწერეთ პროგრამა სადაც მომხმარებელს შემოჰყავს რიცხვი თუ ეს რიცხვი ტოლია 5 - ის ან ტოლია 10 - ის,კონსოლში დაიბეჭდება(რიცხვი უდრის 5 - ს ან რიცხვი უდრის 10 - ს,წინააღმდეგ შემთხვევაში დაიბეჭდება(უცნობი რიცხვი)
            //Console.Write("Please enter the number: ");
            //Int32 num2 = Convert.ToInt32(Console.ReadLine());

            //if (num2 == 5 || num2 == 10)
            //{
            //    Console.WriteLine("The number equals either 5 or 10");
            //}
            //else
            //{
            //    Console.WriteLine("Unknown Number");
            //}


            ////8. დაწერეთ პროგრამა სადაც მომხმარებელს შემოჰყავს რიცხვი, თუ ეს რიცხვი კენტია დაიბეჭდება(რიცხვი არის კენტი) თუ ლუწია დაიბეჭდება(რიცხვი არის ლუწი).შეგახსენებთ რიცხვები რომლებიც უნაშთოდ იყოფა 2 - ზე არის ლუწი რიცხვები.
            //Console.Write("Please enter the number: ");
            //Int32 num3 = Convert.ToInt32(Console.ReadLine());

            //if (num3 % 2 == 0)
            //{
            //    Console.WriteLine("The number is even");
            //}
            //else
            //{
            //    Console.WriteLine("The number is odd");
            //}


            #endregion

            #region Homework - Lesson 4

            //// Task 1 - კალკულატორის ვალიდაცია: კლასში აწყობილ კალკულატორზე დაადეთ ვალიდაციები, ისე რომ შეუძლებელი იყოს არასწორი ინფორმაციის შემოყვანა კონსოლიდან შესაბამის ველებში.

            //while (true)
            //{
            //    int calc1, calc2;
            //    char opr;

            //    Console.Write("Enter first number: ");

            //    try
            //    {
            //        calc1 = int.Parse(Console.ReadLine());
            //    }
            //    catch (FormatException)
            //    {
            //        Console.Write("Invalid input! Please enter a valid number: ");
            //        continue;
            //    }

            //    while (!int.TryParse(Console.ReadLine(), out calc1))
            //    {
            //        Console.Write("Invalid input! Please enter a valid number: ");
            //    }

            //    Console.Write("Enter second number: ");
            //    while (!int.TryParse(Console.ReadLine(), out calc2))
            //    {
            //        Console.Write("Invalid input! Please enter a valid number: ");
            //    }

            //    Console.Write("Enter operator (+, -, *, /): ");
            //    while (!char.TryParse(Console.ReadLine(), out opr) || (opr != '+' && opr != '-' && opr != '*' && opr != '/'))
            //    {
            //        Console.Write("Invalid operator! Please enter one of (+, -, *, /): ");
            //    }

            //    switch (opr)
            //    {
            //        case '+': Console.WriteLine(calc1 + calc2); break;
            //        case '-': Console.WriteLine(calc1 - calc2); break;
            //        case '*': Console.WriteLine(calc1 * calc2); break;
            //        case '/':

            //            if (calc2 == 0)
            //            {
            //                Console.WriteLine("Error: Cannot divide by zero!");
            //            }
            //            else
            //            {
            //                Console.WriteLine((double)calc1 / calc2);
            //            }
            //            break;
            //    }


            //    Console.Write("Press X if you want to quit the application: ");
            //    string response = Console.ReadLine();
            //    if (response == "X")
            //    {
            //        Console.WriteLine("Goodbye!");
            //        break;
            //    }

            //    Console.WriteLine();
            //}


            ////Task 2 - ლოგინის ვალიდაცია: ააწყეთ ლოგინის ფორმა სადაც მომხმარებელს სთხოვთ რომ შემოიყვანოთ email და პაროლი. თქვენი დავალებაა რომ შემოყვანილი email და პროლი იყოს ვალიდური, მაგალითად email შეიცავდეს შესაბამის სიმბოლოებს, და პაროლი შეიცავდეს დიდ/პატარა ასოებს რიცხვებს და სპეციალურ სიმბოლოებს, აპლიკაციის რეალიზება უნდა მოხდეს კონსოლში.



            //string email, password;


            //Console.WriteLine("Please enter your email: ");
            //email = Console.ReadLine();

            //if (!email.Contains("@") && !email.Contains("."))
            //{
            //    Console.WriteLine("Please enter valid email address");
            //}

            //Console.WriteLine();


            //    Console.WriteLine("Please enter the password: ");
            //    password = Console.ReadLine();

            //    if (password.Length < 8)
            //    {
            //    Console.WriteLine("Password should be at least 8 characters");
            //}


            #endregion

            #region ClassWork -  Lesson 5



            //1.Print numbers from 1 to 10

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //while (int p <= 10)
            //{
            //    Console.WriteLine(p);
            //    i++;
            //}



            ////2. Print even numbers from 1 to 20

            //for (int j = 0; j <= 20; j +=2)
            //{
            //    Console.WriteLine(j);
            //}



            ////3. Sum of numbers from 1 to 100

            //int result = 0;
            //for (int j = 0; j < 100; j++)
            //{
            //    result += j;
            //}

            //Console.WriteLine(result);



            ////4. Factorial of a number (5! = 5 * 4 * 3 * 2 * 1)

            //int factorial = int.Parse(Console.ReadLine());
            //int result = 1;

            //for ( int j = factorial; j >= 1; j--)
            //{
            //    result *= j;

            //}

            //Console.WriteLine(result);



            //TODO : 5. Print multiplication table for a number (e.g. 2 * 1 = 2, 2 * 2 = 4, ..., 2 * 10 = 20)

            #endregion

            #region Homework - Lesson 5

            //// Task 1. მომხმარებელს კლავიატურის გამოყენებით შეჰყავს 2 რიცხვი. ჩვენი ამოცანაა, რომ ვაჩვენოთ ყველა
            //// ლუწი რიცხვი მითითებულ დიაპაზონში. თუ დიაპზონის საზღვრები არასწორად არის მოცემული, თქვენ უნდა
            //// ჩაასწოროთ ის.მაგალითად, თუ მომხმარებელმა შეიყვანა 20 და 11, ჩასწორებაა საჭირო, რადგან დიაპაზონის
            ////დასაწყისი უნდა იყოს -11, და დასასრული -20.

            //Console.Write("Please enter the first number of the range: ");
            //int numb1 = int.Parse(Console.ReadLine());

            //Console.Write("Please enter the last number of the range: ");
            //int numb2 = int.Parse(Console.ReadLine());


            //if (numb1 > numb2)
            //{
            //    int tempNumb = numb1;
            //    numb1 = numb2;
            //    numb2 = tempNumb;

            //}
            //for (int i = numb1; i <= numb2; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            ////Task 2. დაწერეთ პროგრამა რომელიც გამოიტანს კონსოლში ფიფქებით შედგენილ ნახევარპირამიდის ფორმას.
            //// მაგალითად ციფრი 4–ის შეყვანისას კონსოლში გამოვა შემდეგი სახის ნახევარ პირამიდა:
            ////*
            ////**
            ////***
            ////****

            //Console.WriteLine("Please enter a number: ");

            //int newNumb = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= newNumb; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            ////Task 3. დაწერეთ პროგრამა რომელიც კონსოლიდან წაკითხული რიცხვის მიხედვით გამოიტანს ციფრებით გამოსახულ
            //// პირამიდას მაგ: შემოტანილი რიცხვია თუ არის 4, გამოსატან პირამიდას ექნება ასეთი სახე:
            ////1
            ////2 2
            ////3 3 3
            ////4 4 4 4

            //Console.WriteLine("Please enter a number: ");

            //int nmb = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= nmb; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Homework -  Lesson 6

            //while (true)
            //{
            //    int calc1, calc2;
            //    char opr;

            //    try
            //    {
            //        Console.WriteLine("Enter first number: ");
            //        if (!int.TryParse(Console.ReadLine(), out calc1))
            //        {
            //            throw new ArgumentException("Invalid input! Please enter a valid number.");
            //        }

            //        Console.WriteLine("Enter second number: ");
            //        if (!int.TryParse(Console.ReadLine(), out calc2))
            //        {
            //            throw new ArgumentException("Invalid input! Please enter a valid number.");
            //        }

            //        Console.WriteLine("Enter operator (+, -, *, /): ");

            //        if (!char.TryParse(Console.ReadLine(), out opr) || (opr != '+' && opr != '-' && opr != '*' && opr != '/'))
            //        {
            //            throw new ArgumentException("Invalid operator! Please enter one of (+, -, *, /): ");
            //        }

            //    }
            //    catch (ArgumentException)
            //    {
            //        Console.WriteLine("Invalid input! Please enter a valid number: ");
            //        continue;
            //    }

            //    switch (opr)
            //    {
            //        case '+': Console.WriteLine(calc1 + calc2); break;
            //        case '-': Console.WriteLine(calc1 - calc2); break;
            //        case '*': Console.WriteLine(calc1 * calc2); break;
            //        case '/':

            //            if (calc2 == 0)
            //            {
            //                Console.WriteLine("Error: Cannot divide by zero!");
            //            }
            //            else
            //            {
            //                Console.WriteLine((double)calc1 / calc2);
            //            }
            //            break;
            //    }

            //    Console.Write("Press X if you want to quit the application: ");
            //    string response = Console.ReadLine();
            //    if (response == "X")
            //    {
            //        Console.WriteLine("Goodbye!");
            //        break;
            //    }

            //    Console.WriteLine();
            //}
            #endregion

            #region Classwork - Lesson 7

            //int [] array = [10,5,3,4,2];

            ////for (int i=0; i< array.Length; i++)
            ////{
            ////    Console.Write(array[i] + " ");
            ////}


            //Console.WriteLine(array[array.Length - 1]);


            //for (int i = 0; i < array.Length - 1; i++)

            //{
            //    for (int j = i + 1; j < array.Length; j++)
            //    {
            //        if (array[i] > array[j])
            //        {
            //            int min = array[j];
            //            array[j] = array[i];
            //            array[i] = min;
            //        }

            //    }
            //    Console.Write(array[i] + " ");
            //}


            #endregion

            #region Homework - Lesson 7


            //int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9];

            ////დაწერეთ კოდი რომელიც გამოთვლის მასივის ელემენტების ჯამს

            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}

            //Console.WriteLine($"Sum of array elements: {sum}");


            ////დაწერეთ კოდი რომელიც მოძებმის მასივის ზომას length - ის გამოყენების გარეშე

            //int length = 0;

            //foreach (var item in arr)
            //{
            //    length++;
            //}
            //Console.WriteLine($"Length of array: {length}");

            ////დაწერეთ კოდი რომელიც დაბეჭდავს მასივს უკუღმა

            //int[] reversedArray = new int[length];

            //Console.WriteLine("Array in reverse order: ");

            //for (int i = arr.Length - 1; i >= 0; i--)
            //    {
            //        Console.Write(arr[i] + " ");
            //    }

            //Console.WriteLine();

            ////დაწერეთ კოდი რომელიც მასივის ყველა ელემენტს გადააკოპირებს მერე მასივში

            //int[] copiedArray = new int[length];

            //Console.WriteLine($"Copied array: ");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    copiedArray[i] = arr[i];
            //    Console.Write(copiedArray[i] + " ");
            //}

            //Console.WriteLine();

            ////დაწერეთ კოდი რომელიც მოძებნის მასივის უნიკალურ ელემენტებს


            //int[] arr1 = [1, 1, 3, 4, 4, 7, 7, 9, 9];

            //int uniqueElement;

            //uniqueElement = 0;

            //Console.WriteLine("Unique elements in the array: ");

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    bool isUnique = true;
            //    for (int j = 0; j < arr1.Length; j++)
            //    {
            //        if (i != j && arr1[i] == arr1[j])
            //        {
            //            isUnique = false;
            //            break;
            //        }
            //    }
            //    if (isUnique)
            //    {
            //        Console.Write(arr1[i] + " ");
            //        uniqueElement++;
            //    }
            //}

            #endregion

            #region Homework - Lesson 8

            //Task1 - Print elements from the array.

            int[] ar = new int[3] { 11, 22, 33 };
            PrintArray(ar);

            string[] array = ["Daisy", "Marc", "Jacobs", "Dior", "Christian"];
            PrintArrayString(array);

            //Task2 - Sort the elements of the array in ascending order and print them.

            int[] ar2 = new int[5] { 5, 3, 8, 1, 4 };

            Console.WriteLine("Original array: ");
            PrintArray(ar2);

            Console.WriteLine("Sorted array in ascending order: ");
            PrintArray(SortAscending(ar2));

            //Task3 - Find the minimum element in the array and print it.

            int[] ar3 = new int[6] { 60, 2, 4, 51, 24, 88 };

            Console.WriteLine("Original array: ");
            PrintArray(ar3);

            Console.WriteLine("Minimum element of the array: ");
            GetMinElement(ar3);

            //Task4 - Find and print the maximum element in the array.

            Console.WriteLine("Original array: ");
            PrintArray(ar3);

            Console.WriteLine("Maximum element of the array: ");
            GetMaxElement(ar3);

            //Task5 – Find and Print the Sum of All Elements:

            Console.WriteLine("Original array: ");
            PrintArray(ar3);
            Console.WriteLine($"Sum of the elements of the array: {GetSumofElements(ar3)}");

            //Task6 – Find and print the Average of Array Elements:

            Console.WriteLine("Original array: ");
            PrintArray(ar3);
            Console.WriteLine($"Average of the elements of the array: {GetAverageOfElements(ar3)}");

            //Task7 – Count and Print Even Numbers in an Array

            Console.WriteLine("Original array: ");
            PrintArray(ar3);
            Console.WriteLine($"Count of even numbers in the array: {CountEvenNumbers(ar3)}");

            //Task8 – Reverse and Print the Array

            Console.WriteLine("Original array: ");
            PrintArray(ar3);

            Console.WriteLine("Reversed array: ");
            PrintArray(ReversedArray(ar3));

            //Task9 – Search for an Element in the Array


            Console.Write("Enter a number to search in the array: ");
            int searchNumber = int.Parse(Console.ReadLine());
            SearchElement(ar3, searchNumber);

            //Task10 – Replace All Odd Numbers with Zero

            Console.WriteLine("Original array: ");
            PrintArray(ar3);

            Console.WriteLine("Array without Odd numbers: ");
            NewArrayWithOddZeroes(ar3);

            //Task11 – Sort and Print Strings Alphabetically

            Console.WriteLine("Original array: ");
            PrintArrayString(array);

            SortAlphabetically(array);

            //Task12 – Find the Longest String in the Array

            string[] array2 = ["Balenciaga", "Loewe", "LW", "Dior", "Chanel"];

            Console.WriteLine("Original array: ");
            PrintArrayString(array2);

            Console.WriteLine($"Longest string in the array: {LongestString(array2)}");

            //Task13 – Copy Array into a New Array

            Console.WriteLine("Original array: ");
            PrintArray(ar2);

            Console.WriteLine("Copied array: ");
            PrintArray(GetDuplicateArray(ar2));

            //Task14 – Merge Two Arrays into a Single One

            Console.WriteLine("First array: ");
            PrintArray(ar);
            Console.WriteLine("Second array: ");
            PrintArray(ar2);
            Console.WriteLine($"Merged Array: ");
            PrintArray(MergeArrays(ar, ar2));

            //Task15 – Count How Many Times a Specific Element Appears in the Array

            // Option 1:

            int[] arr4 = new int[10] { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };

            Console.Write("Please insert the number: ");
            int element = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"The number {element} appears {CountElements(arr4, element)} times in the array.");

            // Option 2:

            Console.WriteLine("Original array: ");
            PrintArray(arr4);

            CountElements2(arr4, element);

            //Task16 – Find the Second Largest Element in the Array

            Console.WriteLine("Original array: ");
            PrintArray(ar3);

            GetSecondLargestElement(ar3);

            //Task17 – Remove Duplicates from an Array

            Console.Write("Array before removing duplicates: ");
            PrintArray(arr4);

            Console.Write("Array after removing duplicates: ");
            RemoveDuplicates(arr4);
            Console.WriteLine();

            //Task18 – Print All Unique Elements in an Array

            Console.WriteLine("Original array: ");
            PrintArray(arr4);

            Console.Write("Unique elements in the array: ");
            GetOnlyUniqueElemenets(arr4);
            Console.WriteLine();

            //Task19 – Shift All Elements One Position to the Left

            Console.WriteLine("Original array: ");
            PrintArray(ar);

            ShiftToLeft(ar);


            //Task20 – Check if an Array is Sorted in Ascending Order

            Console.WriteLine("Original array: ");
            PrintArray(ar3);
            AscendingOrNot(ar3);


            #endregion
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

        }

        static void PrintArrayString(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static int[] SortAscending(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        static void GetMinElement(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.Write($"Minimum element of the array: {min}");
            Console.WriteLine();
        }

        static void GetMaxElement(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.Write($"Maximum element of the array: {max}");
            Console.WriteLine();
        }

        static int GetSumofElements(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        static decimal GetAverageOfElements(int[] array)
        {
            int sum = GetSumofElements(array);
            return Math.Round((decimal) sum / array.Length, 2);
        }

        static int CountEvenNumbers(int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }

        static int[] ReversedArray(int[] array)
        {
            int[] reversed = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                reversed[i] = array[array.Length - 1 - i];
            }
            return reversed;
        }

        static void SearchElement(int[] array, int element)
        {
            bool found = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    found = true;
                    Console.WriteLine($"Element {element} fount at index {i}");
                }
            }
            if (!found)
            {
                Console.WriteLine($"Element {element} is not found.");
            }
        }

        static void NewArrayWithOddZeroes(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    array[i] = 0;
                }
            }
            PrintArray(array);
        }

        static void SortAlphabetically(string[] array)
        {
            Array.Sort(array);
            Console.WriteLine("Sorted array in alphabetical order: ");
            PrintArrayString(array);
        }

        static string LongestString(string[] array)
        {
            int maxLengthIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length >= array[maxLengthIndex].Length)
                {
                    maxLengthIndex = i;
                }
            }
            return array[maxLengthIndex];
        }

        static int[] GetDuplicateArray(int[] array)
        {
            int[] DuplArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                DuplArray[i] = array[i];
            }
            return DuplArray;
        }

        static int[] MergeArrays(int[] array1, int[] array2)
        {
            int[] mergedArray = new int[array1.Length + array2.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                mergedArray[i] = array1[i];
            }
            ;
            for (int i = 0; i < array2.Length; i++)
            {
                mergedArray[array1.Length + i] = array2[i];
            }
            return mergedArray;
        }

        static int CountElements(int[] array, int element)
        {
            int count = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] == element)
                {
                    count++;
                }
            }

            return count;
        }

        static void CountElements2(int[] array, int element)
        {
            int count = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] == element)
                {
                    count++;
                }
            }

            if (count != 0)
            {
                Console.WriteLine($"The number {element} appears {count} times in the array.");
            }
            else
            {
                Console.WriteLine($"The number {element} was not found in the array.");
            }
        }

        static void GetSecondLargestElement(int[] array)
        {
            int firstLargestElement = 0;
            int secondLargestElement = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > firstLargestElement)
                {
                    secondLargestElement = firstLargestElement;
                    firstLargestElement = array[i];
                }
            }
            Console.WriteLine($"Second Largest element is {secondLargestElement}");
        }

        static void RemoveDuplicates(int[] array)
        {
            int[] uniqueArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (!uniqueArray.Contains(array[i]))
                {
                    uniqueArray[i] = array[i];
                    Console.Write(uniqueArray[i] + " ");
                }
            }
        }

        static void GetOnlyUniqueElemenets(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                bool isUnique = true;

                for (int j = 0; j < array.Length; j++)
                {
                    if (i != j && array[i] == array[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }

        static void ShiftToLeft(int[] array)
        {
            int firstElement = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = firstElement;
            Console.WriteLine("Array after shifting to the left: ");
            PrintArray(array);
        }

        static void AscendingOrNot(int[] array)
        {
            bool isAscending = true;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    isAscending = false;
                    break;
                }
            }
            if (isAscending)
            {
                Console.WriteLine("The array is sorted in ascending order.");
            }
            else
            {
                Console.WriteLine("The array is not sorted in ascending order.");
            }
        }
    }
}
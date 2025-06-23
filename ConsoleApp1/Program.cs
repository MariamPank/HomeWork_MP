using System;

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

            while (true)
            {
                int calc1, calc2;
                char opr;

                try
                {
                    Console.WriteLine("Enter first number: ");
                    if (!int.TryParse(Console.ReadLine(), out calc1))
                    {
                        throw new ArgumentException("Invalid input! Please enter a valid number.");
                    }

                    Console.WriteLine("Enter second number: ");
                    if (!int.TryParse(Console.ReadLine(), out calc2))
                    {
                        throw new ArgumentException("Invalid input! Please enter a valid number.");
                    }

                    Console.WriteLine("Enter operator (+, -, *, /): ");

                    if (!char.TryParse(Console.ReadLine(), out opr) || (opr != '+' && opr != '-' && opr != '*' && opr != '/'))
                    {
                        throw new ArgumentException("Invalid operator! Please enter one of (+, -, *, /): ");
                    }

                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Invalid input! Please enter a valid number: ");
                    continue;
                }

                switch (opr)
                {
                    case '+': Console.WriteLine(calc1 + calc2); break;
                    case '-': Console.WriteLine(calc1 - calc2); break;
                    case '*': Console.WriteLine(calc1 * calc2); break;
                    case '/':

                        if (calc2 == 0)
                        {
                            Console.WriteLine("Error: Cannot divide by zero!");
                        }
                        else
                        {
                            Console.WriteLine((double)calc1 / calc2);
                        }
                        break;
                }

                Console.Write("Press X if you want to quit the application: ");
                string response = Console.ReadLine();
                if (response == "X")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                Console.WriteLine();
            }
            #endregion
        }
    }
}
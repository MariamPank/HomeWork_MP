using ConsoleApp1;
using ConsoleApp1.Homework_13___Classes;
using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Xml;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region HomeWork - Lesson 13

            //✅ სავარჯიშო 1: მემკვიდრეობა — "Transport" კლასი
            //ამოცანა:
            //შექმენი მშობელი კლასი Transport, რომელსაც ექნება მეთოდი Move() და ველი Speed.
            //შემდეგ შექმენი შვილობილი კლასი Car, რომელსაც ექნება დამატებით FuelType ველი და Drive() მეთოდი.
            //შექმენით ობიექტები ამ ტიპების მიხედვით.

            Transport bus = new Transport();
            bus.Speed = 100;
            bus.Move(90);

            Car merc = new Car();
            merc.Speed = 100;
            merc.Move(merc.Speed);
            merc.FuelTupe = "Gas";
            merc.Drive(merc.FuelTupe);


            //✅ სავარჯიშო 2: კონსტრუქტორების მემკვიდრეობა — "Shape & Rectangle"
            //ამოცანა:
            //შექმენი კლასი Shape პარამეტრიანი კონსტრუქტორით(name).
            //შემდეგ შექმენი Rectangle კლასი, რომელიც გამოძახებს მშობლის კონსტრუქტორს base(name) - ით.


            Shape square = new Shape("Sqr");

            square.Name = "Hii";

            Console.WriteLine(square.Name);

            Rectangl_e form = new Rectangl_e("Rect");

            Console.WriteLine(form.Name);


            //✅ სავარჯიშო 4: სახელის დამალვა (new) — "Printer & ColorPrinter"
            //ამოცანა:
            //შექმენი Printer კლასი მეთოდით Print().
            //შემდეგ შექმენი ColorPrinter, რომელიც ქმნის იგივე სახელის Print() მეთოდს new- ით და ბეჭდავს სხვა ტექსტს.

            //დავალება:

            //გამოიძახე Print() ორივე ტიპით(Printer და ColorPrinter) და დააკვირდი შედეგს.

            Printer printer = new Printer();

            printer.Print("Workkk");



            Printer printer1 = new Printer();
            printer.Print("Let's print in black and white");

            ColorPrinter colorPrinter = new ColorPrinter();
            colorPrinter.Print(15);

            //✅ სავარჯიშო 5: base საკვანძო სიტყვა — "Animal & Dog"
            // ამოცანა:
            // შექმენი Animal კლასი, რომელშიც იქნება MakeSound() მეთოდი.
            // შემდეგ Dog კლასი რომელიც override-ით შეცვლის და გამოიძახებს base.MakeSound().

            //უნდა დაბეჭდოს:
            //Animal makes sound
            //Dog barks


            Animal animal = new Animal();
            animal.MakeSound();

            Dog dog = new Dog();
            dog.MakeSound();


            // ✅ სავარჯიშო 6: საკუთარი გამონაკლისის კლასი — "InvalidAgeException"
            //ამოცანა:

            //შექმენი ახალი კლასი InvalidAgeException, რომელიც მემკვიდრეობით მიიღებს Exception - ს.

            //დაწერე მეთოდი RegisterUser(int age), რომელიც age< 18 შემთხვევაში აგდებს ამ გამონაკლისს.


            try
            {
                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());
                RegisterUser(age);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }


            static void RegisterUser(int age)
            {
                if (age < 18)
                {
                    throw new InvalidAgeException();
                }

                Console.WriteLine("Age requirement is met!");
            }
            #endregion
        }
    }
}
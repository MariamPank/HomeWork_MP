using Microsoft.VisualBasic;
using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Homework - Lesson 12

            //• შექმენით სტუდენტის კლასი,რომელსაც უნდა ჰქონდეს
            //  სახელი
            //  გვარი
            //  ასაკი(მინიმაური უნდა იყოს 18 წელი  მაქსიმალური 50 წელი)
            //  ქულა(მინიმალური უნდა იყოს 0 მაქსიმალური 100)

            StudentInfo student = new StudentInfo("Mariam", "Pankelashvili", 33, 90.5);

            Console.WriteLine($"Student's Name: {student.FirstName} {student.LastName}");
            Console.WriteLine($"Student's Age: {student.Age}");
            Console.WriteLine($"Student's Score: {student.Score}");

            //• წინა გაკვეთილში მოაცემული კლასები გადააწყეთ property-ებად(ანუ გააკეთეთ ის რაც აგიხსენით გაკვეთილზე).
            //აგრეთვე Account კლასს დაუმატეთ ფუნქციონალი სადაც მომხმარებელი შეძლებს რომ ანგარიში გაანაღოს ან შეავსოს მისთვის სასურველი თანხით.

            PersonalInfo Alex = new PersonalInfo("Alexandra", "Khutsishvili", 50, "1234565432112345654321", "EUR", "12345654321");

            PersonalInfo Ana = new PersonalInfo("Ana", "Khutsishvili", 100, "9876543210987654321098", "USD", "98765432109");

            Console.WriteLine($"Name: {Alex.FirstName} {Alex.LastName}");
            Console.WriteLine($"Balance: {Alex.Account.Balance}");


            Console.WriteLine($"Name: {Ana.FirstName} {Ana.LastName}");
            Console.WriteLine($"Balance: {Ana.Account.Balance}");

            Alex.Deposit(100);

            Console.WriteLine($"Alex's new balance after deposit: {Alex.Account.Balance} {Alex.Account.Ccy}");


            Ana.Withdraw(50);

            Console.WriteLine($"Ana's new balance after withdrawal: {Ana.Account.Balance} {Ana.Account.Ccy}");

            Ana.Transfer(30, Alex);

            Console.WriteLine($"Ana transferred 30 {Ana.Account.Ccy} to Alex.");

            Console.WriteLine($"Alex's new balance: {Alex.Account.Balance} {Alex.Account.Ccy}");
            Console.WriteLine($"Ana's new balance: {Ana.Account.Balance} {Ana.Account.Ccy}");

            #endregion
        }
    }
}

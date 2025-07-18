﻿using System;


namespace Homework_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            🎯 დავალება: "გმირისა და ბოროტმოქმედის ბრძოლა"
            //✅ დავალების აღწერა:
            //დაგეგმე და შექმენი საბაზისო საბრძოლო თამაში C# ენაზე, რომელშიც მონაწილეობს ორი პერსონაჟი: Hero (გმირი) და Villain (ბოროტმოქმედი).
            //თამაშის მიზანია ამ ორი პერსონაჟის ბრძოლა, სადაც თითოეული პერსონაჟი ფლობს თავის უნიკალურ შესაძლებლობას და თავს ესხმის მოწინააღმდეგეს მანამ, სანამ ერთი მათგანი არ დამარცხდება.

            //📌 ტექნიკური მოთხოვნები:
            //1.აბსტრაქცია
            //შექმენი აბსტრაქტული კლასი Character, რომელიც წარმოადგენს ზოგად პერსონაჟს.
            //უნდა შეიცავდეს შემდეგ თვისებებს:
            //string Name
            //int Health
            //უნდა ჰქონდეს შემდეგი მეთოდები:
            //abstract void Attack(Character target) – შეტევის აბსტრაქტული მეთოდი.
            //void TakeDamage(int damage) – რომელიც ამცირებს პერსონაჟის სიცოცხლეს.
            //bool IsAlive – რომელიც ამოწმებს პერსონაჟი ცოცხალია თუ არა.

            //2. მემკვიდრეობა
            //შექმენი ორი კლასი Hero და Villain, რომლებიც მემკვიდრეობას იღებენ Character-ისგან.
            //თითოეულმა კლასმა უნდა დააიმპლემენტოს საკუთარი ვერსია Attack მეთოდისა. მაგალითად:
            //Hero იყენებს ხმალს (sword) და აზიანებს მოწინააღმდეგეს 20 ქულით.
            //Villain იყენებს ჯადოს (fireball) და აზიანებს მოწინააღმდეგეს 25 ქულით.

            //3. პოლიმორფიზმი
            //გამოიყენე პოლიმორფიზმი:
            //შენახე ორივე პერსონაჟი Character ტიპის ცვლადში.
            //გამოიძახე Attack მეთოდი ისე, რომ სწორად იმუშაოს თითოეული ტიპისთვის (გმირისთვის და ბოროტმოქმედისთვის).

            //4. თამაშის კლასი
            //შექმენი კლასი Game, რომელიც აკონტროლებს თამაშის ლოგიკას:
            //ქმნის გმირს და ბოროტმოქმედს.
            //ათამაშებს მათ ერთმანეთთან მანამ, სანამ ერთ-ერთი არ დამარცხდება.
            //ბეჭდავს შეტევის და დაზიანების შეტყობინებებს კონსოლზე.
            //აფიქსირებს გამარჯვებულს.

            //📝 მიწოდების ფორმა:
            //კოდი უნდა იყოს დაყოფილი შესაბამის კლასებად (Character.cs, Hero.cs, Villain.cs, Game.cs, Program.cs).
            //ყველა კლასის კოდი უნდა აკმაყოფილებდეს OOP პრინციპებს.
            //გამოიყენე კომენტარები, სადაც საჭიროა.

            //Game game = new Game();

            //game.Start();



            Console.Write("Enter your birthday: ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            DateTime today = DateTime.Today;

            int age = today.Year - birthday.Year;

            Console.WriteLine($"You are {age} years old.");


        }
    }
}

using System;
using Kescha.Classes;
using KESCHA.Classes;

namespace KESCHA
{
    class Program
    {
        static void Main()
        {
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                string message = 
                    a >= 0 ? "Num is positive!"
                    : "Num is negative!";
                System.Console.WriteLine(message);


                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());

                var operation1 = Console.ReadLine();

                string result = operation1 switch
                {
                    "+" => $"{num1}+{num2}={num1+num2}",
                    "-" => $"{num1}-{num2}={num1-num2}",
                    "*" => $"{num1}*{num2}={num1*num2}",
                    "/" => $"{num1}/{num2}={num1/num2}",
                    _   => "Operation didnt found!"
                };
                System.Console.WriteLine(result);

                string username=Console.ReadLine();
                int age=Convert.ToInt32(Console.ReadLine());
                int userAge=Convert.ToInt32(Console.ReadLine());

                Animal animal = new Bird();
                animal.PrintAgeDif(age, userAge, username);
                
                int ageb=1;
                int userAgeb=25;
                string usernameb="Birdy";
                Bird bird = new Bird(ageb, userAgeb, usernameb);
                bird.Age=20;
                bird.Name="Kasee";
                System.Console.WriteLine($"bird was created in {bird.CreatedDate}");
                bird.PrintAgeDif(ageb, userAgeb, usernameb);
                Cat cat = new Cat(5, 20, "Mosh");
                cat.PrintAgeDif(1,2,"Umidjon");

                cat.PrintAgeDif2(1,5,"Cat");
            }
            catch(FormatException formatExeption)
            {
                System.Console.WriteLine($"Error was thrown. Message: {formatExeption.Message}");
            }
            catch(Exception exception)
            {
                System.Console.WriteLine($"Error was thrown. Type is not known...");
            }
            System.Console.WriteLine($"Program ended...");

        }
    }

}
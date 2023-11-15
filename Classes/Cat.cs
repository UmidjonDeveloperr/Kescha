using System;
using KESCHA.Classes;

namespace Kescha.Classes
{
    public class Cat : Animal
    {
        public Cat(int CatAge, int userCatAge, string userCatName) :
            base(CatAge, userCatAge, userCatName)
        {

        }
        public override void PrintAgeDif(int Age, int userAge, string Name)
        {
            base.PrintAgeDif(Age, userAge, Name);
            System.Console.WriteLine($"Meow, {Name}'s age and Kescha's age difference is {AgeDifferrence}");
        }

        public override void PrintAgeDif2(int Age, int userAge, string Name)
        {
            Console.WriteLine($"Cat, Meow, {Name}'s age and Kescha's age difference is {userAge-Age}");
        }
    }
}
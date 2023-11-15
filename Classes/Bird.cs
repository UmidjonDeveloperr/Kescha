using System.Reflection.Emit;

namespace KESCHA.Classes
{
    public class Bird : Animal
    {
        public Bird(int Age, int userAge, string name) :
        base    (Age, userAge, name)
        {

        }
        public Bird() :
            base ()
            {
                
            }

        public override void PrintAgeDif2(int Age, int userAge, string Name)
        {
            
        }
    }
}
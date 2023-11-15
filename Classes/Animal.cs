namespace KESCHA.Classes
{
    public abstract class Animal
    {
       public int Age;
       public string Name { get; set; }
       public int AgeDifferrence { get; set; }
       public DateTimeOffset CreatedDate { get; set; }

        public abstract void PrintAgeDif2(int Age, int userAge,string Name);

       public int age
       {
            get{
                return Age;
            }
            set{
                if(age>0)
                    Age=value;
            }
        }

        public Animal()
        {
            Age=0;
            Name="No Name";
            AgeDifferrence=0;
        }
        public Animal(int Age, int userAge, string name)
        {
            Name=name;
            CalAgeDifferenceNoReturn(Age,userAge);
            CreatedDate=DateTimeOffset.UtcNow;
            System.Console.WriteLine($"{Name}'s age and Kescha's age difference is {AgeDifferrence}");
        }
        public virtual void PrintAgeDif(int Age, int userAge,string Name)
        {
            AgeDifferrence=userAge-Age;
            Console.WriteLine($"{Name}'s age and Kescha's age difference is {AgeDifferrence}");
        }

        private int CalAgeDifference(int Age, int userAge)
        {
            return userAge-Age;
        }

        private void CalAgeDifferenceNoReturn(int Age, int userAge)
        {
            AgeDifferrence=userAge-Age;
        }
    }
}
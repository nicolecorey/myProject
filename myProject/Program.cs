using System;

namespace myProject
{

    class gym
    {
        private static int _members = 0;
        private int _Id;
        private string _FirstName;
        private string _LastName;

        public gym()
        {
            _Id = 0;
            _FirstName = "";
            _LastName = "";
        }
        public gym(int i, string First, string Last)
        {
            _Id = i;
            _FirstName = First;
            _LastName = Last;
        }

        public void SetId(int Id)
        {
            _Id = Id;
        }

        public void SetFirstName(string First)
        {
            _FirstName = First;
        }

        public void SetLastName(string Last)
        {
            _LastName = Last;
        }
        public void SetMembers()
        {
            _members++;
        }
        public string GetFirstName()
        {
            return _FirstName;
        }
        public string GetLastName()
        {
            return _LastName;
        }
        public int GetId()
        {
            return _Id;
        }
        public int GetMembers()
        {
            return _members;
        }
    }

    class myGym
    {
        static void Main(string[] args)
        {

            gym membership1 = new gym();
            membership1.SetMembers();
            membership1.SetId(1);
            membership1.SetFirstName("John");
            membership1.SetLastName("Smith");
            printInfo(membership1);


            gym membership2 = new gym();
            membership2.SetMembers();
            Console.WriteLine("Please enter membership number: ");
            membership2.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter first name: ");
            membership2.SetFirstName(Console.ReadLine());
            Console.WriteLine("Please enter last name: ");
            membership2.SetLastName(Console.ReadLine());
            printInfo(membership2);


            gym membership3 = new gym(3, "Jane", "Doe");
            membership3.SetMembers();
            printInfo(membership3);


            Console.WriteLine("Please enter membership number: ");
            int tempId = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter first name: ");
            string tempFirstName = Console.ReadLine();
            Console.WriteLine("Please enter the last name: ");
            string tempLastName = Console.ReadLine();
            gym membership4 = new gym(i: tempId, First: tempFirstName, Last: tempLastName);
            membership4.SetMembers();
            printInfo(membership4);

        }

        static void printInfo(gym membership)
        {
            Console.WriteLine("Hello and welcome to the gym!");
            Console.WriteLine($"{membership.GetFirstName()} {membership.GetLastName()} you are signed in!");
            Console.WriteLine($"People working out right now: {membership.GetMembers()}");
            Console.WriteLine(); // line break
        }
    }
}
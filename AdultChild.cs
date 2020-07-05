using System;
using System.Runtime.ExceptionServices;

namespace AdultChild
{
    class AdultChild
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Adult adult1 = new Adult() 
                { FirstName = "Terry", LastName = "Fox" };
            //adult1.FirstName = "TerryNew";
            Child child1 = new Child() 
                { FirstName = "Snooby", LastName = "Bear" };
            Console.WriteLine(adult1.FirstName);
            Console.WriteLine(child1.FirstName);
            /**/
            Console.WriteLine("Array Begins");
            IPerson[] persons = new Adult[2];
            persons[0] = adult1;
            persons[1] = child1;
            /*
            Console.WriteLine(persons[0].FirstName);
            Console.WriteLine(persons[1].FirstName);
            */
            
            foreach (var item in persons)
            {
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.LastName);
            }
            
            
        }
    }
    public interface IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        /*
        public string Do()
        {
            return "not ready";
        }
        */
    }
    public class Adult : IPerson
    {

        //public string FirstName  { get; set; }
        //public string LastName  { get; set; }

        //public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        private string _firstName;
        public string FirstName { get => _firstName; set => _firstName = value; }
        private string _lastName;
        public string LastName { get => _lastName; set => _lastName = value; }
    }
    public class Child : IPerson
    {
        //public string FirstName  { get; set; }
        //public string LastName  { get; set; }
        private string _firstName;
        public string FirstName { get => _firstName; set => _firstName = value; }
        private string _lastName;
        public string LastName { get => _lastName; set => _lastName = value; }
    }

}

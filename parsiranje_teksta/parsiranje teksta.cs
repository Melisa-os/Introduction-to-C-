using System;
namespace MyCsApp
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CityOfBirth { get; set; }

        public Person(string firstName, string lastName, string cityOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            CityOfBirth = cityOfBirth;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} {CityOfBirth}");
        }
    }

    class Program
    {
        static void Main()
        {
            string text = "John.Davidson/Belgrade Michael.Barton/Krakow Ivan.Perkinson/Moscow";

            string[] personData = text.Split(' ');

            Person[] people = new Person[personData.Length];

            for (int i = 0; i < personData.Length; i++)
            {
                string[] parts = personData[i].Split(new char[] { '.', '/' });

                string firstName = parts[0];
                string lastName = parts[1];
                string cityOfBirth = parts[2];

                people[i] = new Person(firstName, lastName, cityOfBirth);
            }

            foreach (Person person in people)
            {
                person.DisplayInfo();
            }
        }
    }

}
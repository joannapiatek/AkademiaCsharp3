using System;
using System.Collections.Generic;

namespace AkademiaCSharp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Kolekcje
            IntroduceCollections();


            // 2. Klasy i obiekty

            var citizen = new Citizen("Ala");
            var teacher = new Teacher("Piotr", 2400);
            var politician = new Politican("Jan", 45645);

            // Metoda wirtrualna w klasie Citizen, 
            // jej wywołanie z klasy Teacher i przeciążenie w klasie Politician
            Console.WriteLine("Podatek obywatela: " + citizen.CalculateTax() + "\n");
            Console.WriteLine("Podatek nauczyciela: " + teacher.CalculateTax() + "\n");
            Console.WriteLine("Podatek polityka: " + politician.CalculateTax() + "\n");

            // 3. Formatowanie wyświetlania obiektów stworzonych klas - zadanie do napisania nr 1. 
            // (Stworzenie klasy CitizenFormatter, dodanie w niej metody i uruchomienie jej

            var formatter = new CitizenFormatter();
            var result = formatter.Format(teacher);
            Console.WriteLine(result);

            // 4. Połączenie stworzonych klas z listami

            var citizens = new List<Citizen>();
            citizens.Add(citizen);
            citizens.Add(teacher);
            citizens.Add(politician);
            foreach (var c in citizens)
            {
                //c.IsTutor - nie da się, bo tylko Teacher ma tą propertę
                c.Income += 100;
                Console.WriteLine(c.Name);
            }


            //Zad.3
            //CreateAndModifyCitizensList();

            Console.ReadKey();
        }

        public static void IntroduceCollections()
        {
            // Single-dimensional array
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }
            numbers[2] = 8;



            // List
            var names = new List<string>()
            {
                "Jan",
                "Ania",
                "Karol"
            };

            // Nie wykona się, bo zmienia obiekt, na którym pracuje
            //foreach (var name in names)
            //{
            //    name = "Jan";
            //}

            var cities = new List<string>();
            cities.Add("Wrocław");
            cities.Add("Kraków");
            cities.Add("Warszawa");
            cities.Add("Katowice");


            // Przykłady metod dla listy
            cities.Sort();
            cities.RemoveAt(cities.Count - 1);

            if (cities.Contains("Katowice"))
            {
                Console.WriteLine("Lista zawiera Katowice");
            }

            cities.Clear();
        }

        //Zad.3 - jak zdążę/ew. domowe
        public static void CreateAndModifyCitizensList()
        {
            var citizens = new List<Citizen>();
            var formatter = new CitizenFormatter();

            var endLoop = 'N';
            do
            {
                Console.WriteLine();
                if (citizens.Count == 0)
                {
                    Console.WriteLine("Lista obywateli jest pusta.");
                }
                else
                {
                    Console.WriteLine("Oto lista obywateli:");
                    foreach (var citizen in citizens)
                    {
                        var formattedResult = formatter.Format(citizen);
                        Console.WriteLine(formattedResult);
                    }
                }

                Console.WriteLine("Czy dodać nowego obywatela do listy?");
                Console.WriteLine("N - nie, T - tak");
                var answer = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (answer == 'T' || answer == 't')
                {
                    Console.WriteLine("Podaj imię:");
                    var name = Console.ReadLine();

                    var citizen = new Citizen(name);
                    citizens.Add(citizen);
                    Console.WriteLine("Obywatel dodany!");
                }


                Console.WriteLine("Czy zakończyć program? (N/T)");
                endLoop = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (endLoop != 'T' || endLoop != 't');
        }
    }
}

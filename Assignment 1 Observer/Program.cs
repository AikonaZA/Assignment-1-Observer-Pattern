using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configure Observer pattern
            ConcreteSubject sKitchen = new ConcreteSubject();
            ConcreteSubject sIngredient = new ConcreteSubject();
            // Sets the predefined observers available
            sKitchen.Attach(new ConcreteObserver(sKitchen, "Kitchen"));
            sIngredient.Attach(new ConcreteObserver(sIngredient, "Ingredient"));

            string ing, kitchen;

            //Setting the Kitchen
            Console.Write("Choose Country SA/US: ");
            kitchen = Console.ReadLine();
            switch (kitchen)
            {
                // Changes the Kitchen observer to be kitchen location
                case "US": sKitchen.SubjectState = "US Kitchen"; break;
                case "us": sKitchen.SubjectState = "US Kitchen"; break;
                case "SA": sKitchen.SubjectState = "SA Kitchen"; break;
                case "sa": sKitchen.SubjectState = "SA Kitchen"; break;
            }
            //Goes through Subject class to ConcreteObserver class to output in the console window
            sKitchen.Notify();

            //Setting the Ingredient
            Console.Write("Choose Ingredient Taco/Burrito: ");
            ing = Console.ReadLine();
            switch (ing)
            {
                // Changes the Ingredient observer to be an ingredient type
                case "Taco": sIngredient.SubjectState = "Taco"; break;
                case "taco": sIngredient.SubjectState = "Taco"; break;
                case "Burrito": sIngredient.SubjectState = "Burrito"; break;
                case "burrito": sIngredient.SubjectState = "Burrito"; break;
            }
            //Goes through Subject class to ConcreteObserver class to output in the console window
            sIngredient.Notify();

            // Wait for user
            Console.ReadKey();
        }
    }
}
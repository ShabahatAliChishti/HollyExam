using System;
using System.Collections.Generic;
using Xunit;

namespace Exam2022
{

    class Item
    {
        public int Weight, Volume;
        public Item(int we, int vo)
        {
            Weight = we;
            Volume = vo;
        }
    }

    class Truck
    {
    }

    public class Uppgift7
    {
        [Fact]
        public void Uppgift()
        {
           // you do not have to do this task but only uppgift5.cs. you will find the task in file map good luck

            // (a) Skriv en klass Truck som har:
            // - En int-property Weight som beskriver väskans egen weight
            // - En int-property MaxVolume som inte kan ändras utifrån
            // - En konstruktor med två argument som sätter värden ovanför
            // - En privat lista med typen Item (se klassen ovan)
            // - Metoder för att lägga till och ta bort Items från listan
            // - En metod för att se hur mycket plats som finns kvar i en truck 
            // - En metod för att se vad en trucks totala weight är (inklusive packning)

            // Kommentera ut följande tester för att kontrollera om du gjort rätt!
            // Truck truck1 = new Truck(5, 40);
            // truck1.Add(new Item(3, 4));
            // truck1.Add(new Item(10, 5));
            // truck1.Add(new Item(2, 2));
            // Assert.Equal(29, truck1.SpaceLeft());
            // Assert.Equal(20, truck1.TotalWeight());

            // (b) Tänk dig att programmet där vår truck används kommer ha många olika typer av objekt
            // som kan fraktas av vår truck. Hur skulle du lättast lösa detta? Motivera ditt svar.

            /**
            Svar:

            */

        }
    }
}

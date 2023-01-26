using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CreatingClasses
{
    /// <summary>
    /// This is the main program that will create person objects
    /// <remarks>Name: Bryan Jake Columbres (Jake)</remarks>
    /// <remarks>Date: Jan 25, 2023</remarks>
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //a
            //Create four objects using the following data
            Person person1 = new Person(1, "Ian","Brooks", "Red", 30, true);
            Person person2 = new Person(2, "Gina", "James", "Red", 18, false);
            Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            //b
            // Display's Gina's information as a sentence that shows her id, first name, last name, and her favorite color
            person2.DisplayPersonInfo();

            //c
            //Display all of Mike's information as a list.
            Console.WriteLine(person3.ToString()); 

            //d
            //Change Ian's favorite color to white, and then print his information as a sentence
            person1.ChangeFavoriteColor();  
            person1.DisplayPersonInfo();   
            
            //e
            //Display Mary's age after 10 years
            person4.GetAgeInTenYears(); 












 

            
        }   
    }
}

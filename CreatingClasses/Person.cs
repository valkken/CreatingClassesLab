using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClasses
{
    /// <summary>
    /// This is the person class that defines several attributes
    /// <remarks>Name: Bryan Jake Columbres (Jake)</remarks>
    /// <remarks>Date: Jan 25, 2023</remarks>
    /// </summary>
    internal class Person
    {
        private int personId;
        private string firstName;
        private string lastName;
        private string favoriteColor;
        private int age;
        private bool isWorking;

        /// <summary>
        /// Constructor for the person class with the following 5 attributes.
        /// </summary>
        /// <param name="personId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="favoriteColor"></param>
        /// <param name="isWorking"></param>
        public Person(int personId, string firstName, string lastName, string favoriteColor,int age, bool isWorking) 
        { 
            this.personId = personId;
            this.firstName = firstName; 
            this.lastName = lastName;   
            this.favoriteColor = favoriteColor;
            this.age = age; 
            this.isWorking = isWorking;
        } 

        /// <summary>
        /// method to print the person's first name, last name and favorite color
        /// in a sentence format
        /// </summary>
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"{this.personId}: {this.firstName} {this.lastName}'s favorite color is {this.favoriteColor}");
        }
        
        /// <summary>
        /// Method to changethe private fields of the person's favorite color to "white"
        /// </summary>
        public void ChangeFavoriteColor()
        {
            this.favoriteColor = "white";
        }

        /// <summary>
        /// Method to calculate the age of the person and print it
        /// </summary>
        public void GetAgeInTenYears()
        {
            int ageTenYears = this.age + 10;
            Console.WriteLine($"{this.firstName}'s age in 10 years is {ageTenYears}.");
        }

        /// <summary>
        /// Overriden string method to display the person's information as a list (Not a traditional list, but as per document)
        /// </summary>
        /// <returns></returns>
        public override string ToString() 
        {
            return $"Person ID:{this.personId}\nFirstName: {this.firstName}\nLastName: {this.lastName}\nFavoriteColor: {this.favoriteColor}\nAge: {this.age}\nIsWorking:{this.isWorking}";
        }
     

    }
}

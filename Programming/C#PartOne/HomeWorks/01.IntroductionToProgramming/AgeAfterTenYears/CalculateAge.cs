/** Write a program to read your age from the 
 * console and print how old you will be after 10 years.*/

namespace AgeAfterTenYears
{
    using System;

    class CalculateAge
    {
        static void Main()
        {
            DateTime birthDay = DateTime.Parse(Console.ReadLine());
            DateTime today = DateTime.Now;

            int age = today.Year - birthDay.Year;

            if (birthDay.Month > today.Month || ((birthDay.Month == today.Month) && (birthDay.Day > today.Day)))
            {
                age--;
            }

            Console.WriteLine(age);
            Console.WriteLine(age + 10);
        }
    }
}

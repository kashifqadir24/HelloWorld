using System;

/* You want to determine the price of a movie ticket for someone given their age.
The prices are as follows: 5 and under (free), 5-14 (7.99), 14-65 (11.99), 65+ (9.99) */

namespace HelloWorld
{
    class MovieTicket
    {
        void Main()
        {
            int userAge;

            Console.Write("Please enter your age: ");
            userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge < 0 || userAge > 100)
            {
                Console.WriteLine("Invalid Age, please visit Customer Service");
            }
            else if (userAge < 5)
                Console.WriteLine("Your movie ticket price is $0");
            else if (userAge < 14)
                Console.WriteLine("Your movie ticket price is $7.99");
            else if (userAge < 65)
                Console.WriteLine("Your movie ticket price is $11.99");
            else
            {
                Console.WriteLine("Your movie ticket price is $9.99");
            }

            Console.Read();
        }
    }
}
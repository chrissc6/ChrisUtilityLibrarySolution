using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChrisUtilityLibrary;

namespace TestChrisUL
{
    //used for testing the library

    class Program
    {
        static void Main(string[] args)
        {
            string[] pnums = { "3228888", "5133228888", "322-8888", "513-322-8888" };

            foreach (var i in pnums)
            {
                Console.WriteLine($"{i}, is " + (Strings.ValidUSPhoneNumber(i) ? "" : " not ") + "valid");
            }

            string[] zips = { "12345", "123456789", "12345-6789", "1234-5689" };

            foreach (var i in zips)
            {
                Console.WriteLine($"{i}, is " + (Strings.ValidUSZipcode(i) ? "" : " not ") + "valid");
            }

            var zip1 = "12345";
            var zip2 = "123456789";
            var zip3 = "12345-6789";

            var zip1valid = Strings.ValidUSZipcode(zip1);
            if (zip1valid)
                Console.WriteLine($"Zip code {zip1} is valid");
            else
            {
                Console.WriteLine($"Zip code {zip1} is not valid");
            }

            var zip2valid = Strings.ValidUSZipcode(zip2);
            if (zip2valid)
                Console.WriteLine($"Zip code {zip2} is valid");
            else
            {
                Console.WriteLine($"Zip code {zip2} is not valid");
            }

            var zip3valid = Strings.ValidUSZipcode(zip3);
            if (zip3valid)
                Console.WriteLine($"Zip code {zip3} is valid");
            else
            {
                Console.WriteLine($"Zip code {zip3} is not valid");
            }

            var phone1 = "322-8888";
            var phone2 = "513-322-8888";
            var phone3 = "3228888";
            var phone4 = "5133228888";

            var phone1valid = Strings.ValidUSPhoneNumber(phone1);
            if (phone1valid)
                Console.WriteLine($"{phone1} is valid");
            else
                Console.WriteLine($"{phone1} is not valid");

            var phone2valid = Strings.ValidUSPhoneNumber(phone2);
            if (phone2valid)
                Console.WriteLine($"{phone2} is valid");
            else
                Console.WriteLine($"{phone2} is not valid");

            var phone3valid = Strings.ValidUSPhoneNumber(phone3);
            if (phone3valid)
                Console.WriteLine($"{phone3} is valid");
            else
                Console.WriteLine($"{phone3} is not valid");

            var phone4valid = Strings.ValidUSPhoneNumber(phone4);
            if (phone4valid)
                Console.WriteLine($"{phone4} is valid");
            else
                Console.WriteLine($"{phone4} is not valid");


            var result = Strings.EqualIgnoreCase("abc", "ABC");
            if(result)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
            Console.ReadKey();
        }
    }
}

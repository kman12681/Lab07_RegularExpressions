using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Lab_07
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            while (again)
            {
                Console.WriteLine("Please enter a valid name.");
                bool NameSuccess = false;
                while (!NameSuccess)

                {
                    Console.WriteLine();
                    Console.WriteLine("A valid name starts with an uppercase letter,\ncontains only letters, and has 30 letters max.");
                    Console.WriteLine();
                    Console.Write("Name: ");
                    string Name = Console.ReadLine();

                    if (IsName(Name))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Thank you.");
                        Console.WriteLine();
                        NameSuccess = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid Name.");
                        Console.WriteLine();
                    }
                }


                Console.WriteLine("Please enter a valid email.");

                bool EmailSuccess = false;
                while (!EmailSuccess)
                {
                    Console.WriteLine();
                    Console.WriteLine("Must have 5-30 characters before the @ with no special characters.\n5-10 characters after the @.\nDomain name 2-3 characters.");
                    Console.WriteLine();
                    Console.Write("Email: ");
                    String Email = Console.ReadLine();

                    if (IsEmail(Email))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Thank you.");
                        Console.WriteLine();
                        EmailSuccess = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Email.");
                        Console.WriteLine();
                    }
                }

                Console.WriteLine("Please enter a valid phone number.");
                bool NumberSuccess = false;
                while (!NumberSuccess)

                {
                    Console.WriteLine();
                    Console.WriteLine("Number must be formatted xxx-xxx-xxxx");
                    Console.WriteLine();
                    Console.Write("Number: ");
                    string Number = Console.ReadLine();

                    if (IsNumber(Number))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Thank you.");
                        Console.WriteLine();
                        NumberSuccess = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid Number.");
                        Console.WriteLine();
                    }

                }

                bool DateSuccess = false;
                while (!DateSuccess)
                {

                    Console.WriteLine("Please enter a valid date (dd/mm/yyyy)");
                    Console.WriteLine();
                    string Date1 = Console.ReadLine();

                    if (IsDate(Date1))

                    {
                        Console.WriteLine();
                        Console.WriteLine("Thanks!");
                        Console.WriteLine();
                        DateSuccess = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid Date.");
                        Console.WriteLine();
                    }

                }


                // the code below isn't proper because the characters between the <> don't have to match in order to pass regex
                bool HtmlSuccess = false;
                while (!HtmlSuccess)
                {
                    Console.WriteLine("Please enter valid html elements\n   <x> (whitespace here) </x>");
                    Console.WriteLine();
                    string HTML = Console.ReadLine();

                    if (IsHTML(HTML))

                    {
                        Console.WriteLine();
                        Console.WriteLine("Thanks!");
                        Console.WriteLine();
                        HtmlSuccess = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid.");
                        Console.WriteLine();
                    }
                }

                again = GetContinue();
            }

        }

        static bool IsName(string nameInput)
        {
            return Regex.IsMatch(nameInput, "[A-Z]{1,1}[a-z]{2,29}");
        }

        static bool IsEmail(string emailInput)
        {
            return Regex.IsMatch(emailInput, @"[A-Za-z0-9]{5,30}@[A-Za-z0-9]{5,10}\.[A-Za-z0-9]{2,3}");
        }

        static bool IsNumber(string phoneInput)
        {
            return Regex.IsMatch(phoneInput, @"\b\d{3}-\d{3}-\d{4}\b");
        }

        static bool IsDate(string dateInput)
        {
            return Regex.IsMatch(dateInput, @"([0]?[1-9]|[1|2][0-9]|[3][0|1])[/]([0]?[1-9]|[1][0-2])[/]([0-9]{4}|[0-9]{2})");
        }

        static bool IsHTML(string HTMLInput)
        {
            return Regex.IsMatch(HTMLInput, @"<[a-z]>[\s]*<[/][a-z]>");
        }

        static bool GetContinue()
        {
            while (true)
            {
                //ask user if they want to continue
                Console.WriteLine();
                Console.Write("Do you want to input again (y/n)? ");
                Console.WriteLine();
                //get string input
                string input = Console.ReadLine();

                //if it's yes, return true
                if (input == "y" || input == "Y")
                {
                    return true;
                }
                //if it's no, return false
                else if (input == "n" || input == "N")
                {
                    return false;
                }
                //anything else, ask again
                Console.WriteLine("\nNot a valid entry\n");
            }

        }
    }
}


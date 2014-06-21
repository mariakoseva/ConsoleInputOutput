using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The program prints information about current company: ");
            Console.WriteLine("Please enter the name of the company: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter the company adress: ");
            string adress = Console.ReadLine();
            Console.WriteLine("Please enter the company phone number: ");
            int phoneNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the company fax number: ");
            int faxNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the company web site: ");
            string webSite= Console.ReadLine();
            Console.WriteLine("Please enter the manager's first name: ");
            string FirstName= Console.ReadLine();
            Console.WriteLine("Please enter the manager's last name: ");
            string lastName= Console.ReadLine();
            Console.WriteLine("Please enter manager's age ");
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the manager's phone number: ");
            int managersPhoneNumber = int.Parse(Console.ReadLine());
        }
    }
}

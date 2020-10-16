using System;
using System.Linq;

namespace VirtualProxy
{
    public static class TestVirtualProxy
    {
        public static void Main(string[] args)
        {
            IContacts contacts = new ContactsProxyImpl();
            var company = new Company("ABC Company", "Alabama", "011-2845-8965", contacts);
            Console.WriteLine($"Company Name: {company.CompanyName}");
            Console.WriteLine($"Company Address: {company.CompanyAddress}");
            Console.WriteLine($"Company Contact No.: {company.CompanyContactNo}");
            Console.WriteLine("Requesting contact list:");
            company.Contacts.Employees().ToList().ForEach(Console.WriteLine);
        }
    }
}

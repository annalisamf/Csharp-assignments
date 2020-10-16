using System;
using System.Runtime.Serialization;

namespace VirtualProxy
{
    public sealed class Company
    {
        public string CompanyName { get; }
        public string CompanyAddress { get; }
        public string CompanyContactNo { get; }
        public IContacts Contacts { get; }

        public Company(string companyName, string companyAddress, string companyContactNo, IContacts contacts)
        {
            CompanyName = companyName;
            CompanyAddress = companyAddress;
            CompanyContactNo = companyContactNo;
            Contacts = contacts;
            Console.WriteLine("Company object created...");
        }
    }
}
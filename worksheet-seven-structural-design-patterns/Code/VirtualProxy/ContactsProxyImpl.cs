using System;
using System.Collections.Generic;

namespace VirtualProxy
{
    public class ContactsProxyImpl : IContacts
    {
        private IContacts _contacts;

        public IList<Employee> Employees()
        {
            if (_contacts != null) return _contacts.Employees();
            Console.WriteLine("Creating contact list and fetching list of employees...");
            _contacts = new ContactsImpl();

            return _contacts.Employees();
        }
    }
}
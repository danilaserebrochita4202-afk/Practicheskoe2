using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practicheskoe2
{
    internal class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public User(string name, string email, int age)
        {
            Name = name;
            Email = email;
            Age = age;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Анна", "anna@gmail.com", 20);
        }
    }
}

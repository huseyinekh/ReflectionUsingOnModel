using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task_2.Models
{
    public class Employe
    {

        public string Username { get; private set; } = default!;
        public string Email { get; private set; } = default!;

        public string setUser(string name, string surname)
        {
            Username = $"{name} {surname}";
            Email = $"{name}{surname}@code.edu.az";
            Console.WriteLine($"{this.GetType().GetProperty("Email").Name}:{Email}");
            return Email;
        }
    }
}

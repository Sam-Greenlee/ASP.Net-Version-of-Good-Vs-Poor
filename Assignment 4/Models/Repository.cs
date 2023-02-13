using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4.Models
{
    public class Repository
    {
        private static List<Registrations> registrations = new List<Registrations>();

        public static IEnumerable<Registrations> Registrations
        {
            get { return registrations; }
        }

        public static void AddRegistration (Registrations registration)
        {
            registrations.Add(registration);


        }
    }
}

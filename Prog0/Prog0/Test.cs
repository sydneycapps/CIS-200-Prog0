//D5236
//CIS 200-01
//Program 0
//09/10/2018
//This is the Test class, which creates a simple console application to test my code.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class ParcelTest
    {
        static void Main(string[] args)
        {
            List<Address> addresses = new List<Address>(); //Initialize new list of addresses
            List<Parcel> parcels = new List<Parcel>();     //Initialize new list of parcels

            //Four Address objects 
            addresses.Add(new Address("Ivy Cat", "1234 Catnip St.", "Meowville", "KY", 56789));
            addresses.Add(new Address("Mia Dog", "9876 Bone St.", "Growlsville", "NY", 78463));
            addresses.Add(new Address("Rex Paw", "321 Treats Blvd.", "Apt. 6", "Barksville", "TN", 31254));
            addresses.Add(new Address("Athena Slithers", "587 Snake Rd.", "Apt. 23", "Hissington", "LA", 87436));

            //Four Letter objects added to Parcel objects.
            parcels.Add(new Letter(addresses[0], addresses[1], 2));
            parcels.Add(new Letter(addresses[3], addresses[0], 4));
            parcels.Add(new Letter(addresses[2], addresses[3], 3));

            //Processes each letter in parcel
            foreach(Letter letter in parcels)
            {
                Console.WriteLine($"{ letter}{ Environment.NewLine}"); 
            }
        }
    }
}

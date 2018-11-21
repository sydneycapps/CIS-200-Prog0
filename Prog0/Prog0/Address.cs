//D5236
//CIS 200-01
//Program 0
//09/10/2018
//This is the Address class, which contains the name, address1, address2, city, state, and zip.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public class Address
    {
        private string _name;       //Backing field for Name
        private string _address1;   //Backing field for Address Line 1
        private string _address2;   //Backing field for Address Line 2
        private string _city;       //Backing field for City
        private string _state;      //Backing field for State
        private int _zip;           //Backing field for Zip Code

        //Preconditions: None
        //Postconditions: The Address object has been initialized for name, address1, address2, city, state, and zip
        public Address(string name, string address1, string address2, string city, string state, int zip)
        {
            Name = name;
            Address1 = address1;
            Address2 = address2;
            City = city;
            State = state;
            Zip = zip;
        }

        //Preconditions: None
        //Postconditions: The Address object has been initialized for name, address1, city, state, and zip
        public Address(string name, string address1, string city, string state, int zip)
        {
            Name = name;
            Address1 = address1;
            City = city;
            State = state;
            Zip = zip;
        }

        //Preconditions: None
        //Postconditions: Name is retrieved and set to the value
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        //Preconditions: None
        //Postconditions: Address1 is retrieved and set to the value
        public string Address1
        {
            get
            {
                return _address1;
            }

            set
            {
                _address1 = value;
            }
        }

        //Preconditions: None
        //Postconditions: Address2 is retrieved and set to the value
        public string Address2
        {
            get
            {
                return _address2;
            }

            set
            {
                    _address2 = value;
            }
        }

        //Preconditions: None
        //Postconditions: City is retrieved and set to the value
        public string City
        {
            get
            {
                return _city;
            }

            set
            {
                _city = value;
            }
        }

        //Preconditions: None
        //Postconditions: State is retrieved and set to the value
        public string State
        {
            get
            {
                return _state;
            }

            set
            {
                _state = value;
            }
        }

        //Preconditions: None
        //Postconditions: Zip is retrieved and set to the value based on it's restrictions
        public int Zip
        {
            get
            {
                return _zip;
            }

            set
            {
                if (value < 0 || value > 99999)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Zip)} must be between 0 and 99999");
                }
                _zip = value;
            }
        }

        //Precondition: None
        //Postcondition: The formatted string of the Address information is returned based on whether
        //               Address2 is present or not
        public override string ToString()
        {
            string formattedAddress;         //Holds the formatted string to return
            string NL = Environment.NewLine; //Shortcut for a new line

            if (string.IsNullOrWhiteSpace(Address2))
                formattedAddress = $"{Name}{NL}" +
                                   $"{Address1}{NL}" +
                                   $"{City}, {State} {Zip:D5}";
            else
                formattedAddress = $"{Name}{NL}" +
                                   $"{Address1}{NL}" +
                                   $"{Address2}{NL}" +
                                   $"{City}, {State} {Zip:D5}";
            return formattedAddress;
        }
    }
}

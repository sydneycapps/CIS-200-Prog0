//D5236
//CIS 200-01
//Program 0
//09/10/2018
//This is the Parcel abstract base class and is at the top of our hierarchy. 
//It contains the to and from addresses for the parcel.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public abstract class Parcel
    {
        //Preconditions: None
        //Postconditions: Origin Address is retreived and set to the value
        public Address OriginAddress { get; set; }

        //Preconditions: None
        //Postconditions: Destination Address is retreived and set to the value
        public Address DestinationAddress { get; set; }

        //Preconditions: None
        //Postconditions: The Parcel object is initialized with the Origin Address and the Destination Address
        //                specified values
        public Parcel(Address oAddress, Address dAddress)
        {
            OriginAddress = oAddress;
            DestinationAddress = dAddress;
        }

        //Precondition: None
        //Postcondition: The cost of the item is calculated
        public abstract decimal CalcCost();

        //Precondition: None
        //Postcondition: The formatted string of the Parcel information is returned 
        public override string ToString()
        {
            return $"Origin Address:{Environment.NewLine}" +
                   $"{OriginAddress}{Environment.NewLine}" +
                   $"{Environment.NewLine}" +
                   $"Destination Address:{Environment.NewLine}" +
                   $"{DestinationAddress}{Environment.NewLine}" +
                   $"{Environment.NewLine}" +
                   $"Cost: {CalcCost():C}{Environment.NewLine}";
        }

    }
}

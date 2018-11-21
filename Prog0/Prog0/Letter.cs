//D5236
//CIS 200-01
//Program 0
//09/10/2018
//This is the Letter class, which specifies the origin address, destination address, and the fixed cost
//of the letter.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class Letter : Parcel
    {
        private decimal _fixedCost; //Backing field for Fixed Cost

        //Preconditions: None
        //Postconditions: The Letter object has been initialized with the Origin Address, Destination Address,
        //                and the Fixed Cost values that have been specified
        public Letter(Address oAddress, Address dAddress, decimal fixedCost)
            :base(oAddress, dAddress)
        {
            FixedCost = fixedCost;
        }

        //Preconditions: None
        //Postconditions: Fixed Cost is retrieved and set to the value
        public decimal FixedCost
        {
            get
            {
                return _fixedCost;
            }

            set
            {
                _fixedCost = value;
            }
        }

        //Preconditions: None
        //Postconditions: CalcCost is set to Fixed Cost
        public override decimal CalcCost()
        {
            return FixedCost;
        }

        //Precondition: None
        //Postcondition: The formatted string of the Letter information is returned
        public override string ToString()
        {
            string NL = Environment.NewLine; //Shortcut for a new line

            return $"Origin Address:{NL}" +
                   $"{OriginAddress}{NL}" +
                   $"{NL}" +
                   $"Destination Address:{NL}" +
                   $"{DestinationAddress}{NL}" +
                   $"{NL}" +
                   $"Cost: {FixedCost:C}{NL}";
        }
    }
}

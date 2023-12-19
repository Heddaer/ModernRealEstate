// Author: Hedda Eriksson
// Date: 2023-10-09 
// Malmö University, Bachelor of Engineering - Computer Science & Telecommunications
// info: Derived class, inherits from Residential -> Estate -> IEstate.
using RealEstateBLL.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateBLL.RealEstate.Residentials
{
    [Serializable]
    public class Apartment : Residential
    {
        private bool balcony;
        private double rent;

        //Default constructor
        public Apartment()
        {
            balcony = false;
            rent = 0.0;
        }

        //first constructor
        public Apartment(string id, ContractType contractType, int area, string imageLocation, Address address, Person person, int nbrOfRooms, bool balcony)
            : base(id, contractType, area, imageLocation, address, person, nbrOfRooms)
        {
            this.balcony = balcony;
            rent = EstimatedRent(contractType, area);
        }

        public override double EstimatedRent(ContractType contract, int area)
        {
            if (balcony)
            {
                return base.EstimatedRent(contract, area) * 0.3;
            }
            return base.EstimatedRent(contract, area);
        }

        public override string ToString()
        {
            string txtout = string.Format("{0}Estimated rent is ${1, 0:F2} {2} Property features: ", Environment.NewLine, rent, Environment.NewLine); ;

            if (balcony)
            {
                txtout += "Balcony";
            }

            return base.ToString() + txtout;
        }
        // GETTERS & SETTERS
        public bool Balcony { get => balcony; set => balcony = value; }
        public double Rent { get => rent; set => rent = value; }
    }
}

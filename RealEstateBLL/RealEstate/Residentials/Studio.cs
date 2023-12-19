// Author: Hedda Eriksson
// Date: 2023-10-09 
// Malmö University, Bachelor of Engineering - Computer Science & Telecommunications
// info: Derived class, inherits from Apartment -> Residential -> Estate -> IEstate.
using RealEstateBLL.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateBLL.RealEstate.Residentials
{
    [Serializable]
    public class Studio : Apartment
    {
        private bool kitchentte;

        //default constructor
        public Studio()
        {
            kitchentte = false;
        }

        //first constructor
        public Studio(string id, ContractType contractType, int area, string imageLocation, Address address, Person person, int nbrOfRooms, bool balcony, bool kitchentte)
             : base(id, contractType, area, imageLocation, address, person, nbrOfRooms, balcony)
        {
            this.kitchentte = kitchentte;
        }

        public override string ToString()
        {
            string txtout = "";
            if (kitchentte)
            {
                txtout = ", Kitchnette";
            }
            return base.ToString() + txtout;
        }

        //GETTERS & SETTERS
        public bool Kitchentte { get => kitchentte; set => kitchentte = value; }
    }
}

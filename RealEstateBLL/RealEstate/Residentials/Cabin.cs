// Author: Hedda Eriksson
// Date: 2023-10-09 
// Malmö University, Bachelor of Engineering - Computer Science & Telecommunications
// info: Derived class, inherits from Villa -> Residential -> Estate -> IEstate.
using RealEstateBLL.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateBLL.RealEstate.Residentials
{
    [Serializable]
    public class Cabin : Villa
    {
        private bool closeLake;

        //default constructor
        public Cabin()
        {
            closeLake = false;
        }

        //first constructor
        public Cabin(string id, ContractType contractType, int area, string imageLocation, Address address, Person person, int nbrOfRooms, bool garage, bool pool, bool closeLake)
            : base(id, contractType, area, imageLocation, address, person, nbrOfRooms, garage, pool)
        {
            this.closeLake = closeLake;
        }

        public override string ToString()
        {
            string txtout = "";
            if (closeLake)
            {
                txtout = ", Close to lake";
            }
            return base.ToString() + txtout;
        }

        //GETTERS & SETTERS
        public bool CloseLake { get => closeLake; set => closeLake = value; }

    }
}

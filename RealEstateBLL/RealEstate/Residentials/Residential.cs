// Author: Hedda Eriksson
// Date: 2023-10-09 
// Malmö University, Bachelor of Engineering - Computer Science & Telecommunications
// info: Derived class, inherits from Estate -> IEstate.
using RealEstateBLL.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateBLL.RealEstate.Residentials
{
    [Serializable]
    public class Residential : Estate
    {
        private double preRent;
        private int nbrOfRooms;

        //default constructor
        public Residential()
        {
            preRent = 0;
            nbrOfRooms = 0;
        }

        //first constructor
        public Residential(string id, ContractType contractType, int area, string imagelocation, Address address, Person person, int nbrOfRooms)
            : base(id, contractType, area, imagelocation, address, person)
        {
            preRent = EstimatedRent(contractType, area);
            this.nbrOfRooms = nbrOfRooms;
        }

        public override double EstimatedRent(ContractType contract, int area)
        {

            if (contract == ContractType.Rental)
            {
                preRent = area * 10.5;
            }
            else if (contract == ContractType.Tenement)
            {
                preRent = area * 10.6;
            }
            else
            {
                preRent = 99;    //default 
            }
            return preRent;
        }

        public override string ToString()
        {
            string txtOut = string.Format("{0}{1} with {2} rooms on {3} sq. meters.",
                Environment.NewLine, this.GetType().Name, NbrOfRooms, Area);
            return base.ToString() + txtOut;
        }

        //GETTERS & SETTERS
        public int NbrOfRooms { get => nbrOfRooms; set => nbrOfRooms = value; }

    }

}

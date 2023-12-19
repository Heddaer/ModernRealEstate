// Author: Hedda Eriksson
// Date: 2023-10-09 
// Malmö University, Bachelor of Engineering - Computer Science & Telecommunications
// info: Derived class, inherits from Estate -> IEstate.
using RealEstateBLL.Persons;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateBLL.RealEstate.Commercials
{
    [Serializable]
    public class Commercial : Estate
    {
        private bool coldStorageRoom;
        private double rent;

        //default constructor
        public Commercial()
        {
            coldStorageRoom = false;
            rent = 0;
        }

        //first constructor
        public Commercial(string id, ContractType contractType, int area, string imageLocation, Address address, bool coldRoom)
            : base(id, contractType, area, imageLocation, address)
        {
            coldStorageRoom = coldRoom;
            rent = EstimatedRent(contractType, area);

        }

        //second constructor
        public Commercial(string id, ContractType contractType, int area, string imageLocation, Address address, Person person, bool coldRoom)
            : base(id, contractType, area, imageLocation, address, person)
        {
            coldStorageRoom = coldRoom;
            rent = EstimatedRent(contractType, area);
        }

        public override double EstimatedRent(ContractType contract, int area)
        {
            if (contract == ContractType.Lease)
            {
                rent = area * 16;
            }
            else
            {
                rent = area * 13;
            }
            return rent;
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("{0}{1} of {2} sq. meters. {3}Property features: ", Environment.NewLine, this.GetType().Name, Area, Environment.NewLine);
        }

        //GETTERS & SETTERS
        public bool ColdStorageRoom { get => coldStorageRoom; set => coldStorageRoom = value; }
        public double Rent { get => rent; set => rent = value; }
    }
}

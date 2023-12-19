// Author: Hedda Eriksson
// Date: 2023-10-09 
// Malmö University, Bachelor of Engineering - Computer Science & Telecommunications
// info: Derived class, inherits from Commercial -> Estate -> IEstate.
using RealEstateBLL.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateBLL.RealEstate.Commercials
{
    [Serializable]
    public class Warehouse : Commercial
    {
        private WarehouseType wType;

        //default constructor
        public Warehouse() { }

        //first constructor
        public Warehouse(string id, ContractType contractType, int area, string imageLocation, Address address, bool coldRoom, WarehouseType type)
            : base(id, contractType, area, imageLocation, address, coldRoom)
        {
            this.wType = type;
            Rent = EstimatedRent(contractType, area);
        }

        //second constructor 
        public Warehouse(string id, ContractType contractType, int area, string imageLocation, Address address, Person person, bool coldRoom, WarehouseType type)
      : base(id, contractType, area, imageLocation, address, person, coldRoom)
        {
            this.wType = type;
            Rent = EstimatedRent(contractType, area);
        }

        public override double EstimatedRent(ContractType contract, int area)
        {
            if (wType == WarehouseType.Smart || wType == WarehouseType.Cold_Storage)
            {
                return base.EstimatedRent(contract, area) + 100;
            }
            else
            {
                return base.EstimatedRent(contract, area);
            }
        }

        public override string ToString()
        {
            string txtOut = string.Format("{0}-warehouse ", wType);
            if (ColdStorageRoom)
            {
                txtOut += ", Cold storage room";
            }
            txtOut += string.Format("{0}Estimated rent is ${1, 0:F2}", Environment.NewLine, Rent);

            return base.ToString() + txtOut;
        }

        //GETTERS & SETTERS
        public WarehouseType WType { get => wType; set => wType = value; }
    }
}

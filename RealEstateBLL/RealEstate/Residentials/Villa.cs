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
    public class Villa : Residential
    {
        private bool garage;
        private bool pool;
        private double rent;

        //default constructor
        public Villa()
        {
            garage = false;
            pool = false;
            rent = 0;
        }

        //first constructor
        public Villa(string id, ContractType contractType, int area, string imageLocation, Address address, Person person, int nbrOfRooms, bool garage, bool pool)
        : base(id, contractType, area, imageLocation, address, person, nbrOfRooms)
        {
            this.garage = garage;
            this.pool = pool;
            rent = EstimatedRent(contractType, area);
        }

        public override double EstimatedRent(ContractType contract, int area)
        {
            if (pool || garage)
            {
                return base.EstimatedRent(contract, area) * 0.3;
            }
            else if (pool && garage)
            {
                return base.EstimatedRent(contract, area) * 0.5;
            }
            else
            {
                return base.EstimatedRent(contract, area);

            }
        }

        public override string ToString()
        {
            string txtout = string.Format("{0}Estimated rent is ${1, 0:F2} {2}Property features: ",
                Environment.NewLine ,rent, Environment.NewLine);

            if (pool && !garage)
            {
                txtout += "Pool";
            }
            else if (garage && !pool)
            {
                txtout += "Garage";
            }
            else if (garage && pool)
            {
                txtout += "Garage, Pool";
            }
            return base.ToString() + txtout;
        }

        //GETTERS & SETTERS
        public bool Garage { get => garage; set => garage = value; }
        public bool Pool { get => pool; set => pool = value; }
    }
}

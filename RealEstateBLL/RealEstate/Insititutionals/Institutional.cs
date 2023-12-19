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

namespace RealEstateBLL.RealEstate.Insititutionals
{
    [Serializable]
    public class Institutional : Estate
    {
        private PurposeType purpose;
        private double rent = 0;
        private int financialContribution = 100;

        //default constructor
        public Institutional() { }

        //first constructor
        public Institutional(string id, ContractType contractType, int area, string imageLocation, Address address, PurposeType purpose)
            : base(id, contractType, area, imageLocation, address)
        {
            this.purpose = purpose;
            if (this.purpose == PurposeType.Educational || this.purpose == PurposeType.Religious)
            {
                rent = EstimatedRent(contractType, area) - financialContribution;
            }
            else
            {
                rent = EstimatedRent(contractType, area);

            }
        }

        //second constructor
        public Institutional(string id, ContractType contractType, int area, string imageLocation, Address address, Person person, PurposeType purpose)
            : base(id, contractType, area, imageLocation, address, person)
        {
            this.purpose = purpose;
            if (this.purpose == PurposeType.Educational || this.purpose == PurposeType.Religious)
            {
                rent = EstimatedRent(contractType, area) - financialContribution;
            }
            else
            {
                rent = EstimatedRent(contractType, area);

            }
        }

        public override double EstimatedRent(ContractType contract, int area)
        {
            return area * 13;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("{0}{1} of {2} sq. meters. {3}Estimated rent is ${4, 0:F2} {5}Property feature: ", Environment.NewLine, this.GetType().Name, Area, Environment.NewLine, rent, Environment.NewLine);
        }

        //GETTERS & SETTERS
        public PurposeType Purpose { get => purpose; set => purpose = value; }

    }
}

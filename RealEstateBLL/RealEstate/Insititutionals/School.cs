// Author: Hedda Eriksson
// Date: 2023-10-09 
// Malmö University, Bachelor of Engineering - Computer Science & Telecommunications
// info: Derived class, inherits from Institutional-> Estate -> IEstate.
using RealEstateBLL.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateBLL.RealEstate.Insititutionals
{
    [Serializable]
    public class School : Institutional
    {
        private int nbrOfClassrooms;
        private bool cafeteria;
        private bool sportsCenter;

        //default constructor
        public School()
        {
            nbrOfClassrooms = 0;
            cafeteria = false;
            sportsCenter = false;
        }

        //first constructor
        public School(string id, ContractType contractType, int area, string imageLocation, Address address, PurposeType purpose, int nbrOfClassrooms, bool cafeteria, bool sportsCenter)
           : base(id, contractType, area, imageLocation, address, purpose)
        {
            this.nbrOfClassrooms = nbrOfClassrooms;
            this.cafeteria = cafeteria;
            this.sportsCenter = sportsCenter;
        }

        //second constructor 
        public School(string id, ContractType contractType, int area, string imageLocation, Address address, Person person, PurposeType purpose, int nbrOfClassrooms, bool cafeteria, bool sportsCenter)
             : base(id, contractType, area, imageLocation, address, person, purpose)
        {
            this.nbrOfClassrooms = nbrOfClassrooms;
            this.cafeteria = cafeteria;
            this.sportsCenter = sportsCenter;
        }


        public override string ToString()
        {
            string txtout = string.Format("{0} Classrooms", nbrOfClassrooms);
            if (cafeteria && sportsCenter)
            {
                txtout += ", Cafeteria, Sports center";
            }
            else if (cafeteria)
            {
                txtout += ", Cafeteria";
            }
            else if (sportsCenter)
            {
                txtout += ", Sports center";
            }
            return base.ToString() + txtout;
        }

        //GETTERS & SETTERS
        public int NbrOfClassrooms { get => nbrOfClassrooms; set => nbrOfClassrooms = value; }
        public bool Cafeteria { get => cafeteria; set => cafeteria = value; }
        public bool SportsCenter { get => sportsCenter; set => sportsCenter = value; }
    }
}

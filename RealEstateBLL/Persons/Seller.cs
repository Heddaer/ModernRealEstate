// Author: Hedda Eriksson
// Date: 2023-10-09 
// Malmö University, Bachelor of Engineering - Computer Science & Telecommunications
// info: derived class Seller, inherits Person and contains information about a seller.
using RealEstateBLL.RealEstate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateBLL.Persons
{
    [Serializable]
    public class Seller : Person
    {
        private string movingOutDate;
        //for legal person selling
        private string companyName;



        public Seller()
        {
            movingOutDate = "default";
            companyName = "default";
        }

        // Constructor legal person selling
        public Seller(string firstName, string lastName, string phoneNbr, string email, 
            Address address, string bank, string companyName, string movingOutDate) 
            : base (firstName, lastName, phoneNbr, email, address, bank) 
        {
            this.companyName = companyName;
            this.movingOutDate = movingOutDate;
        }

        // Constructor private person selling
        public Seller(string firstName, string lastName, string phoneNbr, string email, Address address, string bank, string movingOutDate)
            : base(firstName, lastName, phoneNbr, email, address, bank)
        {
            this.movingOutDate = movingOutDate;
            companyName = "Private Person";
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("{0}Date of moving out: {1} {2}Company: {3}", 
                Environment.NewLine, movingOutDate, Environment.NewLine, companyName);
        }

        //GETTERS & SETTERS
        public string MovingOutDate { get => movingOutDate; set => movingOutDate = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
    }
}

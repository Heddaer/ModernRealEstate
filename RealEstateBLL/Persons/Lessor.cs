// Author: Hedda Eriksson
// Date: 2023-10-09 
// Malmö University, Bachelor of Engineering - Computer Science & Telecommunications
// info: derived class Lessor, contains information about a company who leases/rent out estates.
using RealEstateBLL.RealEstate;

namespace RealEstateBLL.Persons
{
    [Serializable]
    public class Lessor : Person 
    {
        private string companyName;

        //default constructor
        public Lessor() 
        {
            companyName = "default";
        } 

        //first constructor
        public Lessor(string firstName, string lastName, string phoneNbr, string email, Address address, string bank, string companyName)
            : base(firstName, lastName, phoneNbr, email, address, bank)
        {
            this.companyName  = companyName;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("{0}Company: {1}", Environment.NewLine, companyName);
        }
        //GETTERS & SETTERS
        public string CompanyName { get => companyName; set => companyName = value; }
    }
}

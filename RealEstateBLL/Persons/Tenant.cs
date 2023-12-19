// Author: Hedda Eriksson
// Date: 2023-10-09 
// Malmö University, Bachelor of Engineering - Computer Science & Telecommunications
// info: Tenant class is a type of person 
using RealEstateBLL.RealEstate;


namespace RealEstateBLL.Persons
{
    [Serializable]
    public class Tenant : Person
    {
        private bool approvedIncome;
        //default constructor
        public Tenant() 
        { 
            approvedIncome = false;
        }

        //first constructor
        public Tenant(string firstName, string lastName, string phoneNbr, string email, Address address, string bank, bool approvedIncome)
            : base(firstName, lastName, phoneNbr, email, address, bank)
        {
            this.approvedIncome = approvedIncome;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("{0}Approved income: {1} ", Environment.NewLine, approvedIncome.ToString());
        }
        //GETTERS & SETTERS
        public bool ApprovedIncome { get => approvedIncome; set => approvedIncome = value; }
    }
}

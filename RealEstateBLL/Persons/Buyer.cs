// Author: Hedda Eriksson
// Date: 2023-10-09 
// Malmö University, Bachelor of Engineering - Computer Science & Telecommunications
// info: derived class Buyer, inherits Person and contains information about a buyer.
using RealEstateBLL.RealEstate;


namespace RealEstateBLL.Persons
{
    [Serializable]
    public class Buyer : Person
    {
        private bool loanPromise;

        //default constructor
        public Buyer() 
        {
            loanPromise = false;
        }

        //first constructor
        public Buyer(string firstName, string lastName, string phoneNbr, string email, 
            Address address, string bank, bool loanPromise) 
            : base(firstName, lastName, phoneNbr, email, address, bank)
        { 
            this.loanPromise = loanPromise;
        }  

        public override string ToString()
        {
    
            if (loanPromise) 
            {
                return base.ToString() + string.Format("{0}Loan promise: ok ", Environment.NewLine);
            }
            else 
            {
                return base.ToString() + string.Format("{0}Loan promise: pending ", Environment.NewLine);

            }
        }

        // GETTERS & SETTERS
        public bool LoanPromise { get => loanPromise; set => loanPromise = value; }
    }
}

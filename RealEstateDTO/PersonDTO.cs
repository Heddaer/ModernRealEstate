namespace RealEstateDTO
{
    public class PersonDTO
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }   
        public string? PhoneNbr { get; set; }
        public string? Email { get; set; }
        public string? Bank { get; set; }

        public string? PersonType { get; set; }
        public string? CompanyName { get; set; }
        public bool LoanPromise { get; set; }
        public string? MovingOutDate { get; set; }
        public bool ApprovedIncome { get; set; }

    }
}